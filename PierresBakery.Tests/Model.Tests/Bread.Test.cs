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
    public void BreadCost_WillContainPriceofLoaf_Value()
    {
    Bread pricedBread = new Bread(5);
    Assert.AreEqual(typeof(Bread), pricedBread.GetType());
    }
  }
}