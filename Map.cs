using System;

namespace TowerDefence
{

  class Map {

    public readonly int Width;
    public readonly  int Height;

    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }

    public bool OnMap(Point coords)
    {
      return coords.X < Width && coords.X >= 0 && coords.Y < Height && coords.Y >= 0;
      // return !(coords.X >= Width || coords.X < 0 || coords.Y >= Height || coords.Y < 0);
      //Both essentially test the same thing
    }


  }

}
