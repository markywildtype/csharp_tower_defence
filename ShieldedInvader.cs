using System;

namespace TowerDefence{

  class ShieldedInvader : Invader
  {

    private static Random _random = new System.Random();


    public ShieldedInvader(Path path) : base(path)
    {

    }

    public override void DecreaseHealth(int factor)
    {
      if(_random.NextDouble() < 0.5)
      {
        base.DecreaseHealth(factor);
      }
      else
      {
        Console.WriteLine("Shot at a shielded invader, but it sustained no damage!");
      }

    }

  }

}
