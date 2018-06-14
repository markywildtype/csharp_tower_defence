using System;

namespace TowerDefence
{

  class Game {

    public static void Main(string[] args)
    {
      Tower tower = new Tower();
      Map map = new Map(8, 5);

      Point point = new Point(4, 2);
      // bool isOnMap = map.OnMap(point);
      // Console.WriteLine(isOnMap);
      //
      // point = new Point(8, 5);
      // isOnMap = map.OnMap(point);
      // Console.WriteLine(isOnMap);

      // Console.WriteLine(point.DistanceTo(5, 5));
      //
      // //Test Overloaded method and Inherited class:
      // MapLocation point2 = new MapLocation(7, 4);
      // Console.WriteLine(point.DistanceTo(point2));
      // Console.WriteLine(map.OnMap(point2));
      //
      // //Type checking:
      // Console.WriteLine(point2 is MapLocation); //true
      // Console.WriteLine(point2 is Point); //true
      // Console.WriteLine(point is MapLocation); //false
      try {
        MapLocation outOfBounds = new MapLocation(9, 6, map);
      }
      catch(OutOfBoundsException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch(TowerDefenceException)
      {
        Console.WriteLine("Unhandled TowerDefenceException");
      }
      catch(Exception)
      {
        Console.WriteLine("Unhandled Exception");
      }
    }

  }

}
