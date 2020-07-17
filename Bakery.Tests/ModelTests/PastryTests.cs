using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int testPrice = 2;
      Pastry newPastry = new Pastry(3);
      int result = newPastry.Price;
      Assert.AreEqual(testPrice, result);
    }
    [TestMethod]
    public void GetNumberOfPastries_ReturnsNumberOfPastries_Int()
    {
      int testPastries = 3;
      Pastry newPastry = new Pastry(testPastries);
      int result = newPastry.NumberOfPastries;
      Assert.AreEqual(testPastries, result);
    }
    [TestMethod]
    public void TotalPastryPrice_ReturnsPriceBasedOnNumberOfPastries_Int()
    { 
      int testPastries = 2;
      int testPrice = 4;
      Pastry newPastry = new Pastry(testPastries);
      newPastry.TotalPastryPrice();
      int result = newPastry.Price;
      Assert.AreEqual(testPrice, result);
    }
  }
}