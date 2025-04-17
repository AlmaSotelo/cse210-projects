public class Biking : Activity
{
   private double _distance;   
      public Biking(string date, string name, int length, double distance): base (date, name, length)
   {
      _distance = distance;   
   }

   public override double GetDistance()
   {
      return _distance; 
   }
   
   public override double GetSpeed()
   {
      return _distance / _minutes * 60;
   }
   
   public override double GetPace()
   {
      return 60 / GetSpeed();   
   }



}