using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost = 5;
    public int BreadQuanity;
    public Bread(int cost, int quantity)
    {
      BreadCost = cost;
      BreadQuanity = quantity;
    }
    public int BreadOrder ()
    {
      int breadOrder = BreadCost * BreadQuanity;
      return breadOrder;
    }
    public int BreadSpecial ()
    {
      
    }
  }
}