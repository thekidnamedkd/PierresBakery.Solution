using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceofItem_GetT()
    {
    Pastry pricedPastry = new Pastry(2, 3);
    Assert.AreEqual(typeof(Pastry), pricedPastry.GetType());
    }

    [TestMethod]    
    public void PastryOrder_WillContainCostofPastryWithSpecial_Value()
    {
    Pastry pricedPastry = new Pastry(2, 3);
    int pastryDiscount = pricedPastry.PastryOrder();
    Assert.AreEqual(5, pastryDiscount);
    }
  }
}