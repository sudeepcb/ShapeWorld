using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
  // without access modifiers it will assign the most restrictive access modifier but still making the program error free/ (assuming code is written correctly)
  internal class Program
  {

    private static void Main(string[] args)
    {
      PlayWithShape();
    }

    private static void PlayWithShape()
    {

      Shape2D someShape = new Rectangle();

      Square someSquare = new Square();

      Rectangle someRectangle = new Rectangle();

      Shape2D someCube = new Cube();

      someRectangle.Length = 10;
      someRectangle.Width = 100;
      someSquare.Length = 100;

      Console.WriteLine(someCube.NumberOfEdges);
      Console.WriteLine(someSquare.Perimeter());
      Console.WriteLine(someRectangle.Surface());
      Console.WriteLine(someRectangle.Volume());
      Console.WriteLine(someShape.Volume());

    }
  }
}

// how to create a triangle, circle (2D), cube, sphere(3D)
