using System;

namespace TowerDefence
{

  class MapLocation : Point {

    public MapLocation(int x, int y, Map map) : base(x, y)
    {
      if(!map.OnMap(this))
      {
        throw new OutOfBoundsException(x + "," + y + " is outside the bounds of the map.");
      }
    }

  }


}
