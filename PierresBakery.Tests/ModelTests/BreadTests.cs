using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetBreadCost_ReceiveUserInput_Number()
    {
      int userQuantity = Bread.GetBreadCost(3);
      int numberTest = 3;
      Assert.AreEqual(userQuantity, numberTest);
    }
    [TestMethod]
    public void Bread_ReceiveUserQuantity_QtyNumber()
    {
      Bread breadConstructor = new Bread(2);
      Assert.AreEqual(typeof(Bread), breadConstructor.GetType());
    }
  }
}
//discount is (1/3)
//so actualTotal - actualTotal*(1/3) = totalWithDicountApplied

