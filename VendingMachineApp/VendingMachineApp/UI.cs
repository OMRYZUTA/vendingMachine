using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    public static class UI
    {
        public static void ShowMenu(List<String> i_Products)
        {
            int i = 1;
            Console.WriteLine("What do you want to buy?");
            foreach (var product in i_Products)
            {
                Console.WriteLine(string.Format("{0}. {1}", i, product));
                i++;
            }
        }

        internal static void ShowProduct(string i_Response)
        {
            Console.WriteLine(string.Format("There you go, here is the {0}",i_Response));
        }
    }
}
