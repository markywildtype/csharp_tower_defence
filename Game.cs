using System;

namespace TowerDefence
{

  class Game {

    public static void Main(string[] args)
    {
      Map map = new Map(8, 5);

      try {
        Path path = new Path(
            new [] {
              new MapLocation(0, 2, map),
              new MapLocation(1, 2, map),
              new MapLocation(2, 2, map),
              new MapLocation(3, 2, map),
              new MapLocation(4, 2, map),
              new MapLocation(5, 2, map),
              new MapLocation(6, 2, map),
              new MapLocation(7, 2, map)
        });

        Invader[] invaders = {
          new ShieldedInvader(path),
          new FastInvader(path),
          new StrongInvader(path),
          new Invader(path)
        };

        Tower[] towers = {
          new PowerfulTower(new MapLocation(1, 3, map)),
          new SniperTower(new MapLocation(3, 3, map)),
          new LongRangeTower(new MapLocation(5, 3, map))
        };

        Level level1 = new Level(invaders)
        {
          Towers = towers
        };

        bool playerWon = level1.Play();

        Console.WriteLine(playerWon ? "Player has repelled all invaders!" : "Invaders have taken the castle!");

      }
      catch(OutOfBoundsException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch(TowerDefenceException)
      {
        Console.WriteLine("Unhandled TowerDefenceException");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Unhandled Exception: " + ex);
      }

    }

  }

}
