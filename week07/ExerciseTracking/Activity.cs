public abstract class Activity
{
   private string _date;
   private double _minutes;

   public Activity()
   {
      _date = "";
      _minutes = 0;
   }

   public virtual string GetActivitySummaryString()
   {
      return "string";
   }

   public double GetDistance()
   {
      return 0;
   }

   public double GetSpeed()
   {
      return 0;
   }

   public abstract double GetPace();
   
}