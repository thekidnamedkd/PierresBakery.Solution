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
    Pastry pricedPastry = new Pastry(5, 3);
    Assert.AreEqual(typeof(Pastry), pricedPastry.GetType());
    }
  }
}