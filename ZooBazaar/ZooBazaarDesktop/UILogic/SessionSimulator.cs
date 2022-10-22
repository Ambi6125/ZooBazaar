using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarDesktop.UILogic
{
    /// <summary>
    /// Simulates a session throughout the entirity of the WinForms application.
    /// Provides a slot to store an account to simulate login, and provides a dictionary to store
    /// additional items with a key.
    /// </summary>
    internal static class SessionSimulator
    {
        internal static Account? LoggedAccount { get; set; }
        internal static Dictionary<string, object> SessionItems { get; set; } = new Dictionary<string, object>();
    }
}
