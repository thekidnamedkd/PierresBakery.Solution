using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Title = "ASCII Art";
        string title = @"

Welcome to
 _ __  _________ _ __  _ __  ______  __,   _ __    _,  __  ,______ _ __  __   _
( /  )( /(  /   ( /  )( /  )(  / o  (     ( /  )  / | ( /,/(  /   ( /  )( /  / 
 /--'  /   /--   /--<  /--<   /--'   `.    /--<  /--|  /<    /--   /--<  (__/  
/    _/_ (/____//   \_/   \_(/____/(___)  /___/_/   |_/  \_(/____//   \_  _/_  
                                                                         //    
                                                                        (/     
   
Please press 'enter' once to start shopping.";

      Console.WriteLine(title);
      Console.Read();

      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine("Today we have our world famous baked goods. We recommend our bread and our pastries!");
      Console.WriteLine("We have baguettes for $5 and pastries for $2.");
      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine("But if you're looking for a deal:");
      Console.WriteLine("We have buy two, get one on baguettes...");
      Console.WriteLine("And three pastries for 5!");
      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine("How many baguettes would you like?");
      int userBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userPastry = int.Parse(Console.ReadLine());

      Bread breadCalc = new Bread (5, userBread);
      Pastry pastryCalc = new Pastry (2, userPastry);

      int breadTotal = breadCalc.BreadOrder();
      int pastryTotal = pastryCalc.PastryOrder();
      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine(" ");
      Console.WriteLine("Your baguettes will cost: $" + breadTotal);
      Console.WriteLine("Your pastries will cost: $" + pastryTotal);
      Console.WriteLine(" ");
      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine(" ");
      Console.WriteLine("Your grand total is $" + (breadTotal + pastryTotal));
      Console.WriteLine(" ");
      Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
      Console.WriteLine(" ");
      Console.WriteLine("Thank you for order.");
      Console.WriteLine("We will have those bagged and ready for you in just a moment.");
      Console.WriteLine("Please come again soon!");
      Console.Title = "ASCII Art";
        string goodbye = @"

 _ __   ___  _ __    _,   ____  __   _  _,    ,___ ______   
( /  ) /  ()( /  )  ( |  //  ()( /  /  / |   /   /(  /     /
 /--< /   /  /  /     | //   /  (__/  /--|  /  __   /--   / 
/___/(___/  /  (_     |/(___/    _/__/   |_(___/  (/____/'  
                                //                      o   
                               (/                           
";
      Console.WriteLine(goodbye);
    }
  }
}