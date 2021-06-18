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
            ProductTypes.Add("Chocolates");
            ProductTypes.Add("Candy");
            ProductTypes.Add("Cold-drink");
        }
        public void Start()
        {
            Console.WriteLine("What do you want to buy?");
        }

        public string TryGet(string i_Product)
        {
            String result =null;
            if (ProductTypes.Contains(i_Product))
            {
                result = i_Product;
            }
            return result;
        }
    }
}