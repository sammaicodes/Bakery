using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_ReceiveUserQuantity_QtyNumber()
    {
      Bread breadConstructor = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadConstructor.GetType());
    }
   
  }
}


