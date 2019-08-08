using ShapeWorld.Domain.Models;

namespace ShapeWorld.Domain.Collections
{
  public class ShapeArray
  {
    public void DimensionalArray()
    {
      //literal array (telling exactly what it is)
      Shape[] shaped = new Shape[10];
      Shape[] shaped2 = new Shape[] { new Square() };

      //2-D
      Shape[,] shaped3 = new Shape[2, 2];
      Shape[,] shaped4 = new Shape[,]
      {
            {new Square(), new Square()},
            {new Cube(), new Triangle()}

      };

      //3-D
      Shape[,,] shaped5 = new Shape[2,3,4];
      

    }
  }
}