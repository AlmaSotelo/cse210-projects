using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

/*     for (int i = 0; i < 5; i++)
      {
         Console.Write("|");
         Thread.Sleep(400);
         Console.Write("\b \b");
         Console.Write("/");
         Thread.Sleep(400);
         Console.Write("\b \b");
         Console.Write("-");
         Thread.Sleep(400);
         Console.Write("\b \b");
         Console.Write("\\");
         Thread.Sleep(400);
         Console.Write("\b \b"); 
      } */
      for (int i=5; i>0; i--)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }

    }
}