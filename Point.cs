using System;

namespace TowerDefence
{

  class Point
  {

    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public int DistanceTo(int x, int y)
    {
      // int xDiff = X - x;
      // int yDiff = Y - y;
      //
      // int xDiffSquared = xDiff * xDiff;
      // int yDiffSquared = yDiff * yDiff;
      //
      // return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

      //Write as above to get it working then
      //refactor to:
      return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

    }

    //Overloaded method:
    public int DistanceTo(Point point)
    {
      return DistanceTo(point.X, point.Y);
    }


  }

}
