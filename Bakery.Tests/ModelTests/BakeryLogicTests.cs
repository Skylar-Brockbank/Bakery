using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryObjects;
using System;

namespace BakeryObjects.Tests
{
  [TestClass]
  public class BreadTests:IDisposable
  {
    public void Dispose()
    {
      Bread.resetValues();
    }
    [TestMethod]
    public void BreadConstructor_IncrementsTheStaticCounter_int()
    {
      new Bread(2);
      Assert.AreEqual(2, Bread.breadCounter);
    }
    [TestMethod]
    public void BreadConstructor_IncrementsTheStaticCounterCorrectly_int()
    {
      new Bread(2);
      Assert.AreNotEqual(3, Bread.breadCounter);
    }
    [TestMethod]
    public void getPrice_returnsValues_int()
    {
      new Bread(2);
      Assert.AreEqual(10, Bread.getPrice());
    }
    [TestMethod]
    public void getPrice_appliesDeals_int()
    {
      new Bread(3);
      Assert.AreEqual(10, Bread.getPrice());
    }
  } 
  [TestClass]
  public class PastryTests:IDisposable
  {
    public void Dispose()
    {
      Pastry.resetValues();
    }
    [TestMethod]
    public void PastryConstructor_IncrementsTheStaticCounter_int()
    {
      new Pastry(4);
      Assert.AreEqual(4, Pastry.pastryCounter);
    }
    [TestMethod]
    public void PastryConstructor_IncrementsTheStaticCounterCorrectly_int()
    {
      new Pastry(4);
      Assert.AreNotEqual(3, Pastry.pastryCounter);
    }
    [TestMethod]
    public void getPrice_returnsValues_int()
    {
      new Pastry(2);
      Assert.AreEqual(3, Pastry.getPrice());
      new Pastry(2);
      Assert.AreEqual(7, Pastry.getPrice());
      new Pastry(1);
      Assert.AreEqual(9, Pastry.getPrice());
    }
  }
}