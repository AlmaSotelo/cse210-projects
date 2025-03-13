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

   
}