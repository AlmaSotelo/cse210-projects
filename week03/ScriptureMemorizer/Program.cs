using System;

//++++++++ Exceeds core requirements: Randomly reverses the staus of words to Show() in the case the user type "help". ++++++++++++
class Program
{
    static void Main(string[] args)    
    {        
        // Initialize a scripture with not book number, but with end verse
        //1. pass reference info to a new reference object
        Reference reference1 = new Reference("Proverbs", 3,5, 6);
        string text1 = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        //2. pass text info to a new Scripture object
        Scripture scripture1 = new Scripture(reference1, text1);

        // Initialize a scripture with book number and not end verse
        //1. pass reference info to a new reference object
         Reference reference2 = new Reference(1,"Nephi",5,17);
        string text2 = "And it came to pass that I, Nephi, did cause my people to be industrious, and to labor with their hands.";
         //2. pass text info to a new Scripture object
        Scripture scripture2 = new Scripture(reference2, text2);
        
        // Initialize a scripture with not book number and not end verse
        //1. pass reference info to a new reference object
        Reference reference3 = new Reference("Alma",36,1);
        string text3 = "My son, give ear to my words; for I swear unto you, that inasmuch as ye shall keep the commandments of God ye shall prosper in the land.";
        //2. pass text info to a new Scripture object
        Scripture scripture3 = new Scripture(reference3, text3);
      
        // Start. using reference 1
        while (!scripture1.IsCompleteHidden())
        {
            Console.Clear();
            //how the program works
            Console.WriteLine("This program helps you to memorize scritures.\n");    

            SetDisplayScripture(scripture1);

            Console.WriteLine("\nClick enter to hide some words, type quit to 'quit' the program at any time, and type 'help' to show some words already hidden ");
            string userInput = Console.ReadLine();
                        
            if (userInput.ToLower() == "quit")
                break;

            if (userInput.ToLower() == "help") 
            {              
              //show 2 words each time
              SetUnHiddenRandomWords(scripture1, 2);               
            }
            else            
              //hide 2 words each time
              SetHiddenRandomWords(scripture1, 2);                         
        } 
        
        // before the program closes, clear and display the current state of the text
        Console.Clear();
        SetDisplayScripture(scripture1);
        
    }

    // Indirectly retrive the current state of the scripture through Scripture class.
    static void SetDisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
    }

    // Indirectly retrive the words hadden through Scripture calss. 
    static void SetHiddenRandomWords(Scripture scripture, int numberOfWordsToHide)
    {
        scripture.HideRandomWords(numberOfWordsToHide);
    }

    // Indirectly retrive the words newly unhadden through Scripture calss. 
    static void SetUnHiddenRandomWords(Scripture scripture, int numberOfWordsToUnhide)
    {
        scripture.UnhideRandomWords(numberOfWordsToUnhide);
    }
}    
    
    
    

