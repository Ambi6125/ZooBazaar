using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarLogicLayer.Mail.Presets
{
    public class AccountCreationPreset : MailPreset
    {
        private readonly Account account;
        private readonly string unhashedPassword;
        public override string Message =>
                $"Dear employee," +
                $"\nThank you for joining us at ZooBazaar!" +
                $"\nYour account has been created with the following username: {account.Username}" +
                $"\nYour password is {unhashedPassword}. Please log in to change it as soon as possible" +
                $"\n" +
                $"Kind regards, ZooBazaar";

        public override string Subject => "Your ZooBazaarAccount";

        public override bool IsHtml => false;

        public override bool EnableSsl => true;

        public AccountCreationPreset(Account a, string unhashedPassword)
        {
            account = a;
            this.unhashedPassword = unhashedPassword;
        }

        public override string CredentialKey => "MorbinTime";
    }
}
