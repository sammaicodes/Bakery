
namespace Bakery.Models
{
  public class Bread
  {
    public int actualValue {get; }
    public Bread(int userQuantity)
    {
      actualValue = userQuantity*5;
    }
    public static int GetBreadCost(int quantity)
    {
      
      return 3;
    }
  }
}

