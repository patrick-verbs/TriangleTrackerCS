using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.TriangleClass;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    private Triangle _triangleObject = new Triangle();

    [TestMethod]
    public void TypeOfTriangle_NotATriangle()
    {
      Assert.AreEqual("Not a Triangle", _triangleObject.TypeOfTriangle(4, 3, 20));
    }

    [TestMethod]
    public void TypeOfTriangle_Equilateral()
    {
      Assert.AreEqual("Equilateral Triangle", _triangleObject.TypeOfTriangle(5, 5, 5));
    }

    [TestMethod]
    public void TypeOfTriangle_Isosceles()
    {
      Assert.AreEqual("Isosceles Triangle", _triangleObject.TypeOfTriangle(3, 3, 5));
    }

    [TestMethod]
    public void TypeOfTriangle_Scalene()
    {
      Assert.AreEqual("Scalene Triangle", _triangleObject.TypeOfTriangle(3, 4, 5));
    }
  }
}