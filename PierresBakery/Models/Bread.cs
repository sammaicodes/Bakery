
namespace Bakery.Models
{
  public class Bread
  {
    public int value {get; }
    public Bread(int valuePerloaf)
    {
      value = valuePerloaf;
    }
    public int GetBreadCost(int quantity)
    {
      

      return 3;
    }
  }
}

