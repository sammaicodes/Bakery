using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_ReceiveUserQuantity_QtyNumber()
    {
      Bread breadConstructor = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadConstructor.GetType());
    }
    [TestMethod]
    public void GetBreadCost_ReceiveUserTotal_Total()
    {
      int num = 10;
      Bread breadConstructor = new Bread(3);
      Assert.AreEqual(breadConstructor.GetBreadCost(3), num);
    }
  }
}


