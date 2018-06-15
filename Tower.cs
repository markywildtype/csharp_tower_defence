using System;

namespace TowerDefence
{

  class Tower {

    private readonly MapLocation _location;
    private const int _range = 1;
    private const int _power = 10;
    private const double _accuracy = 0.75;

    private static readonly Random _random = new Random();

    public Tower(MapLocation location)
    {
      _location = location;
    }

    public bool IsSuccessfulShot()
    {
      return Tower._random.NextDouble() < _accuracy;
    }


    public void FireOnInvaders(Invader[] invaders)
    {
      foreach(Invader invader in invaders)
      {

        if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
        {
          if(IsSuccessfulShot())
          {
            invader.DecreaseHealth(_power);
            Console.WriteLine("Hit one of the invaders!");
            if(invader.IsNeutralised)
            {
              Console.WriteLine("Invader neutralised! Woohoo!");
            }
          }
          else
          {
            Console.WriteLine("Missed... Try again!");
          }
          break;
        }
      }

    }

  }

}
