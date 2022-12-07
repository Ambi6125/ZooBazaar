using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarLogicLayer.Tickets
{
    public class Ticket
    {
        private int? id;

        private DateTime date;

        private double price;

        private Account owner;

        public double Price => price;

        public Ticket(DateTime date, double price, Account owner)
        {
            this.date = date;
            this.price = price;
            this.owner = owner;
        }

        public virtual double CalculatePrice() => price;
    }
}
