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
    
    Assert.AreEqual(typeof(Bread), pricedBread.GetType());
    }
  }
}