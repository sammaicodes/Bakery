using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Deals of the day:");
      Console.WriteLine("~ On bread: Buy 2, get 1 free, and a single loaf costs $5.");
      Console.WriteLine("~ On pastries: Buy 3 for $5 or buy 1 for $2");
      
      Console.Write("How many loaves would you like to buy? ");
      string stringBreadQty = Console.ReadLine();
      int userBreadQty = int.Parse(stringBreadQty);
      Bread breadConstructor = new Bread(userBreadQty);
      int breadCost = breadConstructor.GetBreadCost(userBreadQty);

      Console.Write("How many pastries would you like to buy? ");
      string stringPastryQty = Console.ReadLine();
      int userPastryQty = int.Parse(stringPastryQty);
      Pastry pastryConstructor = new Pastry(userPastryQty);
      int pastryCost = pastryConstructor.GetPastryCost(userPastryQty);
      int totalWithDiscount = breadCost + pastryCost;
      Console.Write("We appreciate your buisiness! Your total cost is $");
      Console.Write(totalWithDiscount);
    }
  }
}