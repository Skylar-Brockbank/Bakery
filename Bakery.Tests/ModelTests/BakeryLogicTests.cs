using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryObjects;

namespace BakeryObjects.Tests
{
  [TestClass]
  public class BreadTests
  {
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
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_IncrementsTheStaticCounter_int()
    {
      new Pastry(4);
      Assert.AreEqual(4, Pastry.pastryCounter);
    }
  }
}