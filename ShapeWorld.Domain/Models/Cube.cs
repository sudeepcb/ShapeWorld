using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{

  public class Cube : Square, IThreeD
  {
    public double Height { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override double Perimeter()
    {
      return 2 * (Length * Width);
    }

    public override double Surface()
    {
      return Length * Width;
    }

    public new double Volume()
    {
      return Surface() * 10;
    }
    //controllers
    public Cube()
    {

    }
  }



}