public abstract class Activity
{
   private string _name;
   private string _date;
   protected int _minutes;   
      


   public Activity(string date, string name, int length)
   {
      _date = date;
      _name = name;
      _minutes = length;
   }

   public virtual string GetSummary()
   {
      return $"* {_date} {_name} ({_minutes})- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
   }

   public abstract double GetDistance();
   
   public abstract double GetSpeed();
   
   public abstract double GetPace();
   
}