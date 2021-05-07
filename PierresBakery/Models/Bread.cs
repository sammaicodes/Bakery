
namespace Bakery.Models
{
  public class Bread
  {
    public int actualValue {get; }
    public Bread(int userQuantity)
    {
      actualValue = userQuantity*5;
    }
    public int GetBreadCost(int userQuantity)
    {
      int calculate = (userQuantity/3);
      int totalWithDicountApplied = (actualValue - calculate);
      return totalWithDicountApplied;
      // int totalWithDicountApplied = actualValue - (actualValue*(.333));
      // return totalWithDicountApplied;
    }
  }
}

