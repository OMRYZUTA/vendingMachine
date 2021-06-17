using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendingMachines;

namespace VendingMachineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetProductTypes()
        {
            VendingMachine vendingMachine = new VendingMachine();
            List<String> ProductTypes = new List<String>();
            ProductTypes.Add("chocolates");
            ProductTypes.Add("candy");
            ProductTypes.Add("cold-drink");
            List<String> ProductTypesFromVendingMachine = vendingMachine.ProductTypes;
            bool result;
            foreach (String ProductType in ProductTypes)
            {
                result = ProductTypesFromVendingMachine.Contains(ProductType);
                Assert.IsTrue(result, String.Format("Expected for '{0}' : True; Actual :{1}", ProductType, result));
            }
        }
    }
}