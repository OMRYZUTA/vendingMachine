using System;
using System.Collections.Generic;
namespace VendingMachines
{
    public class VendingMachine
    {
        public List<String> ProductTypes { get; set; }
        //public ChangeMoney ChangeMoney { get; set; }
        public VendingMachine()
        {
            ProductTypes = new List<String>();
            setProductTypes();
        }
        private void setProductTypes()
        {
            ProductTypes.Add("chocolates");
            ProductTypes.Add("candy");
            ProductTypes.Add("cold-drink");
        }
        public void Start()
        {
            Console.WriteLine("What do you want to buy?");
        }
    }
}