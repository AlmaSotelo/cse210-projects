public class Swimming : Activity
{
   private int _laps;

   public Swimming(string date, string name, int length, int laps): base (date, name, length)
   {
      _laps = laps;   
   }

   public override double GetDistance()
   {
      return _laps * 50 / 1000 * 0.62;
   }
   
   public override double GetSpeed()
   {
      return GetDistance()/_minutes * 60;
   }
   
   public override double GetPace()
   {
      return _minutes / GetDistance();   
   }



}