
namespace Bakery.Models
{
  public class Bread
  {
    public int ActualBreadValue {get; }
    public int BreadPrice {get; }
    public Bread(int userQuantity)
    {
      BreadPrice = 5;
      ActualBreadValue = userQuantity*BreadPrice;
    }
    public int GetBreadCost(int userQuantity)
    {
      int calculate = (userQuantity/3)*BreadPrice;
      int totalWithDicountApplied = (ActualBreadValue - calculate);
      return totalWithDicountApplied;
    }
  }
}

