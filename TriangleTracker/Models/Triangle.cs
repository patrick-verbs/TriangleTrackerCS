namespace TriangleTracker.TriangleClass
{
  public class Triangle
  {
    public string TypeOfTriangle(int side1, int side2, int side3)
    {
      if(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
      {
        return "Not a Triangle";
      }
      else if(side1 == side2 && side1 == side3)
      {
        return "false";
      }
      return "Error";
    }
  }
}