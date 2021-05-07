using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Test
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesConstructor_QtyNumber()
    {
      Pastry breadConstructor = new Pastry(7);
      Assert.AreEqual(typeof(Pastry), breadConstructor.GetType());
    }
    [TestMethod]
    public void GetPastryCost_ReturnTotalCost_TotalCost()
    {
      Pastry pastryConstructor = new Pastry(7);
      int totalForPastries = 12;
      Assert.AreEqual(pastryConstructor.GetPastryCost(7), totalForPastries);
    }
  }
}


