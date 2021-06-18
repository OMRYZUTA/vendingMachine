using System;
using System.Collections.Generic;
using VendingMachineApp;

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
            try
            {
                while (true)
                {
                    UI.ShowMenu(VendingMachine.ProductTypes);
                    string request = Console.ReadLine();
                    String response = null;
                    if (request.ToLower() == "q")
                    {
                        break;
                    }
                    else
                    {
                        response = getVendingMachineResponse(request);

                    }
                    if (response == null)
                    {
                        throw new Exception(string.Format("out of {0}", request));
                    }
                    else
                    {
                        UI.ShowProduct(response);
                    }
                }
            }
            catch (Exception ex)
            {

                if(ex.Message.Contains("Wrong"))
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("please Try again");
                    Run();
                }
                else if(ex.Message.Contains("out"))
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again tomorrow");
                    Run();
                }
            }
            
        }

        private static string getVendingMachineResponse(string request)
        {
            string response;
            switch (request)
            {
                case "1":
                    response = VendingMachine.TryGet("Chocolates");
                    break;
                case "2":
                    response = VendingMachine.TryGet("Candy");
                    break;
                case "3":
                    response = VendingMachine.TryGet("Cold-drink");
                    break;
                default:
                    throw new Exception(string.Format("Wrong input {0}", request)); 
            }
            return response;
        }
    }
}
