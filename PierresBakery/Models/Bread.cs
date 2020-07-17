using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost;
    public int BreadQuantity;
    public Bread(int cost, int quantity)
    {
      BreadCost = cost;
      BreadQuantity = quantity;
    }
    public int BreadOrder ()
    {
      int breadOrder = BreadCost * BreadQuantity;
      return breadOrder;
    }
      public int BreadSpecial ()
    {
      if (BreadQuantity >= 2) 
      {
        int discount = BreadQuantity/3;
        int breadSpecial = ((BreadQuantity - discount) * BreadCost);
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