using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        
        //takes: string date, string name, int length, double distance
        Running runForLives = new Running("04 Jul 2023","Running for Lives",30,3.5);
        _activities.Add(runForLives);
        //string date, string name, int length, double distance
        Biking bikingFun = new Biking("24 Dec 2023", "Biking for Fun", 50, 18);
        _activities.Add(bikingFun);
        Swimming swimmingT = new Swimming("31 Jan 2024", "Swimming Training", 20, 75);
        _activities.Add(swimmingT);

        int i=0;
        foreach (Activity activity in _activities)
        {
            _activities[i].GetDistance();
            _activities[i].GetSpeed();
            _activities[i].GetPace();
            Console.WriteLine(activity.GetSummary());
            i++;
        }   
        
    }
}