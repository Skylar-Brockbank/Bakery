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
  }
}