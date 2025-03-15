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
        Journal myJournal = new Journal();
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

                case "5":

                    break;

            }


        } while (userOption != "5");












        



    }

}