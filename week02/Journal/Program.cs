using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        string userOption;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do ? ");
            userOption = Console.ReadLine();
            Journal myJournal = new Journal();
            if (userOption == "1")
            {
                //create an instance of Entry class.
                Entry entry = new Entry();                           
                entry._date = entry.GetDate();           
                
                entry._rnmprompt = entry.GetPrompt();
                Console.WriteLine(entry._rnmprompt);

                //let the user enter the writing
                Console.Write(">");                
                entry._message = Console.ReadLine();                              
                             
                              
                myJournal.AddEntry(entry);
                
                myJournal.Display();
            }
             
            if (userOption == "2")
            {
                         
                myJournal.Display();                
                
            }    
        } while (userOption != "5");
        

        
        
        
          
        
        
        



        // Open the file to read from.
        /*string filename = "journal.txt";
        string [] lines = System.IO.File.ReadAllLines (filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string message = parts[2];
            Console.WriteLine($"{date} : {prompt}");
            Console.WriteLine(message);            
        } */
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
       
 
   }
    
}