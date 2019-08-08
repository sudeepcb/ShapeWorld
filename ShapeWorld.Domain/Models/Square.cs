namespace ShapeWorld.Domain.Models
{
    
    public class Square : Rectangle
    {
      //fields 
      // properties
      //methods

    private double _sameLength;

    public override double Length
    {
      get
      {
        return _sameLength;
      }
      set
      {
        _sameLength = value;
      }

    }

    public override double Width
    {
      get
      {
        return _sameLength;
      }
      set
      {
        _sameLength = value;
      }

    }
    
    
    public override double Surface()
    {
      return Length * Width;
    }
    public override double Perimeter(){
      return 2*(Length * Width);
      //controllers
    }
  }
}