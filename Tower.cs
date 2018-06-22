using System;

namespace TowerDefence
{

  class Tower {

    private readonly MapLocation _location;
    
    protected virtual int Range { get; } = 1;
    protected virtual int Power { get; } = 10;
    protected virtual double Accuracy { get; } = 0.75;

    private static readonly Random _random = new Random();

    public Tower(MapLocation location)
    {
      _location = location;
    }

    public bool IsSuccessfulShot()
    {
      return Tower._random.NextDouble() < Accuracy;
    }


    public void FireOnInvaders(Invader[] invaders)
    {
      foreach(Invader invader in invaders)
      {

        if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
        {
          if(IsSuccessfulShot())
          {
            invader.DecreaseHealth(Power);
            // Console.WriteLine("Hit one of the invaders!");
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
