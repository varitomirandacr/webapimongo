using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMongo.Base;
using WebApiMongo.Contracts;

namespace WebApiMongo.Models
{
    // Abstract class: Template brinda herramientas: datos, metodos, etc, pattern, Principle, Practice: Base class
    // Interface: contract, methods and 
    public class Expense : BaseWallet
    {
        public Expense()
        {
            // We work on Panama time
            _lastUpdated = DateTime.Today.AddHours(+1);
        }

        // baking field
        private DateTime _lastUpdated;
        //public new DateTime LastUpdated 
        //{ 
        //    get => _lastUpdated;
        //}
        public void Calculate()
        {
            var test = this.LastUpdated;
        }
    }
}


