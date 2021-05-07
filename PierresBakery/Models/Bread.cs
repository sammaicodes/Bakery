
namespace Bakery.Models
{
  public class Bread
  {
    public int actualBreadValue {get; }
    public Bread(int userQuantity)
    {
      actualBreadValue = userQuantity*5;
    }
    public int GetBreadCost(int userQuantity)
    {
      int calculate = (userQuantity/3)*5;
      int totalWithDicountApplied = (actualBreadValue - calculate);
      return totalWithDicountApplied;
    }
  }
}

