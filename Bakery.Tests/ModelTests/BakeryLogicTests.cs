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
  }
}