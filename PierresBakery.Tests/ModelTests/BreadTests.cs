using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateBreadCost_ReceiveUserInput_Number()
    {
      int userQuantity = Bread.CalculateBreadCost(3);
      int numberTest = 3;
      Assert.AreEqual(userQuantity, numberTest);
    }
  }
}