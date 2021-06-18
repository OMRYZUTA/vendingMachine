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
            ProductTypes.Add("Chocolates");
            ProductTypes.Add("Candy");
            ProductTypes.Add("Cold-drink");
            List<String> ProductTypesFromVendingMachine = vendingMachine.ProductTypes;
            bool result;
            foreach (String ProductType in ProductTypes)
            {
                result = ProductTypesFromVendingMachine.Contains(ProductType);
                Assert.IsTrue(result, String.Format("Expected for '{0}' : True; Actual :{1}", ProductType, result));
            }
        }
        [TestMethod]
        public void TestVendingMachineTryGet()
        {
            VendingMachine vendingMachine = new VendingMachine();
            string choclate =vendingMachine.TryGet("Chocolates");
            Assert.AreEqual<String>(choclate,"Chocolates");
            string candy = vendingMachine.TryGet("Candy");
            Assert.AreEqual<String>(candy, "Candy");
            string coldDrink = vendingMachine.TryGet("Cold-drink");
            Assert.AreEqual<String>(coldDrink, "Cold-drink");
            String error = vendingMachine.TryGet("chicken");
            Assert.IsNull(error);
        }
    }
}