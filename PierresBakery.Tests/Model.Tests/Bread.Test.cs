using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceofItem_GetType()
    {
    Bread pricedBread = new Bread(0);
    Assert.AreEqual(typeof(Bread), pricedBread.GetType());
    }
    public void BreadCost_WillContainPriceofLoaf_Value()
    {
    Bread pricedBread = new Bread(0);
    Assert.AreEqual(5, pricedBread.ApplyCost());
    }
  }
}