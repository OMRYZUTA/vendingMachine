using System;
using System.Collections.Generic;

namespace VendingMachines

{
    public static class Program
    {
        internal static VendingMachine VendingMachine { get; set; }

        public static void Main()
        {
            Run();
        }
        public static void Run()
        {
            VendingMachine = new VendingMachine();
            VendingMachine.Start();
            List<String> products= VendingMachine.ProductTypes;
            int i = 1;
            while (true)
            {
                Console.WriteLine("What do you want to buy?");
                foreach (var product in products)
                {
                    Console.WriteLine(string.Format("{0}. {1}",i,product));
                    i++;
                }
                string result = Console.ReadLine();
                Console.WriteLine(result);
            }
        }
    }
}
