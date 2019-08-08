namespace ShapeWorld.Domain.Models
{
    
    public abstract class Shape2D
    {
      //fields 
      // properties

      public int NumberOfEdges {get; private set;}
      public virtual double Perimeter()
      {
        return 0;
      }

       public abstract double Surface();
      //methods

       public double Volume(){
         return 0;
       }

      //controllers
      public Shape2D(int edges){
        NumberOfEdges = edges;
      }
    }



}