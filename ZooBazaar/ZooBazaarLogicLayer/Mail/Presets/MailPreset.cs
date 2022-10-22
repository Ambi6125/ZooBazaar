using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Mail.Presets
{
    public abstract class MailPreset
    {
        public abstract string Message { get; }
        public abstract string Subject { get; }
        public abstract bool IsHtml { get; }
        public abstract bool EnableSsl { get; }
        public abstract string CredentialKey { get; }
    }
}
