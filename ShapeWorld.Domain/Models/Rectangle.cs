namespace ShapeWorld.Domain.Models
{

  public class Rectangle : Shape2D
  {
    public virtual double Length { get; set; }

    public virtual double Width { get; set; }
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
    public Rectangle() : base(4)
    {

    }
  }



}