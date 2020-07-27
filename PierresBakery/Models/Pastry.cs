using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
  public int PastryCost { get; set; }
  public int PastryQuantity { get; set; }
  public Pastry(int cost, int quantity)
  {
    PastryCost = cost;
    PastryQuantity = quantity;
  }
  public int PastryOrder ()
    {
      if (PastryQuantity % 3 == 0) 
      {
        int discount = PastryQuantity/3;
        int PastrySpecial = (PastryCost * PastryQuantity - discount);
        return PastrySpecial;
      }
      else
      {
        int pastryNonSpecial = PastryQuantity * PastryCost;
        return pastryNonSpecial;
      }
    }
  }
}