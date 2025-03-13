public class Resume
{
    // The C# convention is to start member variables with an underscore _
        public string _name = "";
        //create an instance of built-in List<T> where we'll store data of type Job 
        public List<Job> _jobs = new List<Job>();

        // A method that displays the resume's details with no parameters and no returns
        public void Display() 
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            //iterate through each Job instance in the list of jobs and display them
            foreach(Job job in _jobs)
            {
               job.Display();              
            }
        }        
}        