using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }
    public int BreadQuantity { get; set; }
    public Bread(int cost, int quantity)
    {
      BreadCost = cost;
      BreadQuantity = quantity;
    }
      public int BreadOrder ()
    {
      if (BreadQuantity >= 2) 
      {
        int discount = BreadQuantity/3;
        int breadSpecial = (BreadCost * (BreadQuantity - discount));
        return breadSpecial;
      }
      else 
      {
        int breadNonSpecial = BreadCost * BreadQuantity;
        return breadNonSpecial;
      }
    }
  }
}