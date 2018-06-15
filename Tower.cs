using System;

namespace TowerDefence
{

  class Tower {

    private readonly MapLocation _location;

    private const int _range = 1;

    private const int _power = 10;

    public Tower(MapLocation location)
    {
      _location = location;
    }

    public void FireOnInvaders(Invader[] invaders)
    {
      foreach(Invader invader in invaders)
      {
        if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
        {
          invader.DecreaseHealth(_power);
          break;
        }
      }

    }

  }

}
