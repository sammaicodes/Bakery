
namespace Bakery.Models
{
  public class Pastry
  {
    public int discountDolarValue {get; }
    public Pastry(int userQuantity)
    {
      discountDolarValue = userQuantity/3;
    }
    public int GetPastryCost(int userQuantity)
    {
      int totalWithDicountApplied = (userQuantity*2) - discountDolarValue;
      return totalWithDicountApplied;
    }
  }
}