using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyTools.RegexTools;
using System.Net.Mail;
using ZooBazaarLogicLayer.People;
using EasyTools.Validation;
using ZooBazaarLogicLayer.Mail.Presets;

namespace ZooBazaarLogicLayer.Mail
{
    /// <summary>
    /// Contains 1 mail and provides functionality to write it.
    /// </summary>
    public sealed class MailWriter
    {
        private readonly string sender;
        private string receiver = null;

        public bool EnableSsl { get; set; }
        public bool IsHtml { get; set; }

        public string? CredentialKey { get; set; }

        /// <summary>
        /// The subject of the current mail.
        /// </summary>
        public string? Subject { get; set; }
        /// <summary>
        /// The body of the mail.
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// The recipient(s) of the mail. Split the addressed with commas.
        /// </summary>
        public string Receiver
        {
            get
            {
                return receiver;
            }
            set
            {
                if (RegexToolBox.IsEmail(value))
                {
                    receiver = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid email address");
                }
            }
        }
        public MailWriter(string sender)
        {
            if (!RegexToolBox.IsEmail(sender))
                throw new ArgumentException("Not a valid email address");
            this.sender = sender;
        }

        private bool CheckIfValuesValid()
        {
            return
                sender is not null
                &&
                !string.IsNullOrWhiteSpace(receiver)
                &&
                !string.IsNullOrWhiteSpace(Message)
                &&
                !string.IsNullOrWhiteSpace(Subject);
        }

        public IValidationResponse Send()
        {
            if (string.IsNullOrWhiteSpace(Receiver))
            {
                return new ValidationResponse(false, "No recipient specified.");
            }
            if (!CheckIfValuesValid())
            {
                return new ValidationResponse(false, "Not all details are specified");
            }
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(sender);
                    mail.Subject = Subject;
                    mail.To.Add(Receiver);
                    mail.Body = Message;
                    mail.IsBodyHtml = IsHtml;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(sender, CredentialKey);
                        smtp.EnableSsl = EnableSsl;
                        smtp.Send(mail);
                    }
                }
                return new ValidationResponse(true, "Succesfully sent mail.");
            }
            catch (ArgumentNullException)
            {
                return new ValidationResponse(false, "One or more arguments were not provided.");
            }
            catch (ObjectDisposedException)
            {
                return new ValidationResponse(false, "Mail client was disposed.");
            }
            catch(SmtpException ex)
            {
                return new ValidationResponse(false, ex.Message);
            }
        }

        public void Configure(MailPreset preset)
        {
            CredentialKey = preset.CredentialKey;
            Message = preset.Message;
            Subject = preset.Subject;
            IsHtml = preset.IsHtml;
            EnableSsl = preset.EnableSsl;
        }

        public override string ToString()
        {
            return $"From: {sender}\nSubject: {Subject}\nTo: {Receiver}\n{Message}";
        }
    }
}
