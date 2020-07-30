using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-=-=-=-=-");
      Console.WriteLine("Today we have our world famous baked goods. We recommend our bread and our pastries!");
      Console.WriteLine("We have baguettes for $5 and pastries for $2.");
      Console.WriteLine("-=-=-=-=-");
      Console.WriteLine("But if you're looking for a deal:");
      Console.WriteLine("We have buy two, get one on baguettes...");
      Console.WriteLine("And three pastries for 5!");
      Console.WriteLine("-=-=-=-=-");
      Console.WriteLine("How many baguettes would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());

      Bread breadCalc = new Bread (5, userBread);
      Pastry pastryCalc = new Pastry (2, userPastry);

      int breadTotal = breadCalc.BreadOrder();
      int pastryTotal = pastryCalc.PastryOrder();

      Console.WriteLine("Your baguettes will cost: $" + breadTotal);
      Console.WriteLine("Your pastries will cost: $" + pastryTotal);
      
      Console.WriteLine("Would you like to checkout or add to your order? Type 'checkout' or 'add'");
      Console.ReadLine();
    }
  }
}