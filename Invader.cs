using System;

namespace TowerDefence
{

  class Invader {
    //Fields:
    private readonly Path _path;
    //Private field - starts at 0 - all invaders start on the first step
    private int _pathStep = 0;

    protected virtual int StepSize { get; } = 1;

    //Properties:
    //Auto-property:
    // public MapLocation Location { get; private set; }
    //Replace property with computed property:
    // public MapLocation Location
    // {
    //   get
    //   {
    //     return _path.GetLocationAt(_pathStep);
    //   }
    // }
    //Simplify computed property:
    public MapLocation Location => _path.GetLocationAt(_pathStep);

    public virtual int Health { get; protected set; } = 20;

    public bool HasScored
    {
      get
      {
        return _pathStep >= _path.Length;
      }
    }

    public bool IsNeutralised => Health <= 0;

    public bool IsActive => !(IsNeutralised || HasScored);

    //Constructor
    public Invader(Path path)
    {
      _path = path;
    }

    //Methods:
    public void Move() => _pathStep += StepSize;

    public virtual void DecreaseHealth(int factor)
    {
      Health -= factor;
      Console.WriteLine("Hit one of the invaders!");
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
