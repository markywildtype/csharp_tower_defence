using System;

namespace TowerDefence
{

  class StrongInvader : Invader
  {

    public override int Health { get; protected set; } = 30;

    public StrongInvader(Path path) : base(path)
    {

    }

  }

}
