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
    Bread pricedBread = new Bread(5);
    Assert.AreEqual(typeof(Bread), pricedBread.GetType());
    }
  }
}