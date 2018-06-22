using System;

namespace TowerDefence
{

  class PowerfulTower : Tower
  {

    protected override int Power { get; } = 20;

    public PowerfulTower(MapLocation location) : base(location)
    {

    }

  }

}
