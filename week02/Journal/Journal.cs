using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public class Journal
{
   //create an instance of built-in List<T> where we'll store data of type Entry

    // a method that recives new entries of type Entry, and has not returns
   public List<Entry> _entries = new List<Entry>(); 
   public void AddEntry(Entry newEntry)
   { 
      _entries.Add(newEntry);     
   }
public void Display()
   {
      foreach (Entry entry in _entries)
      {
         entry.Display();
      }   
   }
    
   public void FileSaver(string fileName)
   {
      // create the file in append mode 
      using (StreamWriter outputFile = new StreamWriter(fileName))
      
      foreach (Entry entry in _entries)
      {
         // add text to the file with the Write/WriteLine methods 
         outputFile.Write($"Date: {entry._date} - ,");
         outputFile.Write($"Prompt: {entry._rnmprompt} ,");
         outputFile.WriteLine($"{entry._message}");
      }   
   }

   public  void FileLoader()
   {
      // Open the file to read from.
      string [] lines = System.IO.File.ReadAllLines ("journal.txt");
      foreach (string line in lines)
      {
      string[] parts = line.Split(",");
      string date = parts[0];
      string prompt = parts[1];
      string message = parts[2];
      Console.WriteLine($"{date} : {prompt}");
      Console.WriteLine(message);            
      } 
      
   }
     
}