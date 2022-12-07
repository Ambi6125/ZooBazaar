using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarLogicLayer.Tickets
{
    public class SeniorTicket : Ticket
    {
        public SeniorTicket(DateTime date, double price, Account owner) : base(date, price, owner)
        {
        }

        public override double CalculatePrice()
        {
            return Price * 0.8;
        }
    }
}
