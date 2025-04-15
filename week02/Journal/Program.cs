using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        string userOption;
        Journal myJournal = new Journal();
        int counter = 0;
        string exiting = "";
        //Exceeds core 1(a): outter loop to confirm exiting.
        while (exiting != "y")
        {
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

                if (userOption is "1" or "2" or "3" or "4")
                {
                    counter++;
                    switch (userOption)
                    {
                        case "1":

                            //create an instance of Entry class.
                            Entry entry = new Entry();
                            entry._date = entry.GetDate();

                            entry._rnmprompt = entry.GetPrompt();
                            Console.WriteLine(entry._rnmprompt);

                            //let the user enter the writing
                            Console.Write(">");
                            entry._message = Console.ReadLine();

                            myJournal.AddEntry(entry);

                            break;

                        case "2":
                            myJournal.Display();

                            break;

                        case "3":
                            myJournal.FileLoader();

                            break;

                        case "4":
                            Console.WriteLine("Enter the name of the file: ");
                            string filename = Console.ReadLine();
                            myJournal.FileSaver(filename);

                            break;
                    }
                }
                //Exceeds core 2: evaluate an acceptable input
                else if (userOption != "5")
                {
                    Console.WriteLine("Enter a valid answer (1,2,3,4 or 5) ");
                }

            } while (userOption != "5");

            //Exceeds core 1(b): if the user did not enter any options 1,2,3, or 4, but jumps to option 5 right after accesing the program, then, is asked to connfirm his exit.
            if (counter == 0)
            {
                Console.Write("Are you sure you want to leave? y/n? ");
                exiting = Console.ReadLine();
                if (exiting == "y")
                {
                    Console.WriteLine("Bye now");
                }
            }
            
            //Exceeds core  1(c): the user have no confirmation for exiting, but a nice good by after actually using the program
            else{                
                Console.WriteLine("Thank you for visiting. See you soon.");
                exiting = "y";
            }
        }

    }

}