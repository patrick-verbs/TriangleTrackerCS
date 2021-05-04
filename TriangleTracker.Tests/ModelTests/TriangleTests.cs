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

    [TestMethod]
    public void TypeOfTriangle_Equilateral()
    {
      Triangle triangleObject = new Triangle();
      Assert.AreEqual("Equilateral Triangle", triangleObject.TypeOfTriangle(5, 5, 5));
    }
  }
}