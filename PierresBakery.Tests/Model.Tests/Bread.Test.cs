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
    public void BreadConstructor_CreateInstanceofItem_GetT()
    {
    Bread pricedBread = new Bread(5, 3);
    Assert.AreEqual(typeof(Bread), pricedBread.GetType());
    }
    [TestMethod]
    public void BreadCost_WillContainPriceofLoaf_Value()
    {
    Bread pricedBread = new Bread(5, 3);
    Assert.AreEqual(5, pricedBread.BreadCost);
    }
    [TestMethod]    
    public void BreadQuantity_WillContainNumberofLoaves_Value()
    {
    Bread pricedBread = new Bread(5, 3);
    Assert.AreEqual(3, pricedBread.BreadQuanity);
    }
    [TestMethod]    
    public void BreadOrder_WillContainTotalCostofBread_Value()
    {
    Bread pricedBread = new Bread(5, 3);
    int breadTotal = pricedBread.BreadOrder();
    Assert.AreEqual(15, breadTotal);
    }
    [TestMethod]    
    public void BreadSpecial_WillContainCostofBread_Value()
    {
    Bread pricedBread = new Bread(5, 3);
    int bread= pricedBread.BreadSpecial();
    Assert.AreEqual(10, breadSpecialCost);
    }
  }
}