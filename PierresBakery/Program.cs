using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("- - -");
      Console.WriteLine("Today we have many baked goods. We recommend our bread and our pastries!");
      Console.WriteLine("We have baguettes for 5 and pastries for 2.");
      Console.WriteLine("- - -");
      Console.WriteLine("If you're looking for deal:");
      Console.WriteLine("We have buy two, get one on baguettes...");
      Console.WriteLine("And three pastries for 5!");
      Console.WriteLine("- - -");
      Console.WriteLine("How many baguettes would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());
    }
  }
}