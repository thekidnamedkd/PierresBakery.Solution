using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost;
    public int BreadQuanity;
    public Bread(int cost, int quantity)
    {
      BreadCost = cost;
      BreadQuanity = quantity;
    }
  }
}