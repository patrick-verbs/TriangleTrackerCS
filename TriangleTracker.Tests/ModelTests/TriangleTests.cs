using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.TriangleClass;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TypeOfTriangle_NotATriangle()
    {
      Triangle triangleObject = new Triangle();
      Assert.AreEqual("Not a Triangle", triangleObject.TypeOfTriangle(4, 3, 20));
    }
  }
}