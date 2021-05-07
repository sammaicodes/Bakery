
namespace Bakery.Models
{
  public class Bread
  {
    public double actualValue {get; }
    public Bread(double userQuantity)
    {
      actualValue = userQuantity*5;
    }
    public double GetBreadCost()
    {
      double totalWithDicountApplied = actualValue - (actualValue*(.333));
      return totalWithDicountApplied;
    }
  }
}

