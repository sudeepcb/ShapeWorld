using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{

  public class Sphere : Shape2D, IThreeD
  {
    public virtual double Length { get; set; }

    public virtual double Width { get; set; }
    double IThreeD.Height { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

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

    double IThreeD.Volume()
    {
      throw new System.NotImplementedException();
    }

    //controllers
    public Sphere() : base(4)
    {

    }
  }



}