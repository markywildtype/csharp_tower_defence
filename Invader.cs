using System;

namespace TowerDefence
{

  class Invader {

    private readonly Path _path;
    //Private field - starts at 0 - all invaders start on the first step
    private int _pathStep = 0;
    //Auto-property
    // public MapLocation Location { get; private set; }
    //Replace property with computed property:
    public MapLocation Location
    {
      get
      {
        return _path.GetLocationAt(_pathStep);
      }
    }

    //Constructor
    public Invader(Path path)
    {
      _path = path;
    }

    public void Move()
    {
      _pathStep++;
    }

    // private MapLocation _location;

    //Property accessor:
    // public MapLocation Location
    // {
    //   get
    //   {
    //     return _location;
    //   }
    //   private set
    //   {
    //     _location = value;
    //   }
    //
    // }

  }

}
