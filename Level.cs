using System;

namespace TowerDefence
{

  class Level
  {

    private readonly Invader[] _invaders;

    public Tower[] Towers { get; set; }

    public Level(Invader[] invaders)
    {
      _invaders = invaders;
    }

    //returns true if the player wins, false if they lose.
    public bool Play()
    {
      //Run until all invaders are neutralised or an invader reaches the end of the pathStep
      int remainingInvaders = _invaders.Length;
      while (remainingInvaders > 0)
      {
        foreach(Tower tower in Towers)
        {
          tower.FireOnInvaders(_invaders);
          //Each tower has an opportunity to fire on invaders
        }
        remainingInvaders = 0;
        foreach(Invader invader in _invaders)
        {
          if(invader.IsActive)
          {
            invader.Move();
            if(invader.HasScored){
              return false; //signifies user has lost
            }
            remainingInvaders++;
          }
        }
        //Count and move invaders that are stll active
      }
      return true;
    }


  }

}
