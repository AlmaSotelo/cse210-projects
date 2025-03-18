using System;
using System.Reflection.Metadata.Ecma335;
public class Fraction
{
   private int _top;
   private int _bottom;

   public Fraction()
   {
      _top = 1;
      _bottom = 1;
   }
   public Fraction(int mytop)
   {
      _top = mytop;
      _bottom = 1;      
   }
   public Fraction(int top , int bottom)
   {
      _top = top;
      _bottom = bottom;
   } 
   // I did these for Step 5 that says create Getters and Setter but I don't understand for what....
   public int GetTop()
   {      
      return _top;
   }
   public int SetTop(int top)
   {      
      return _top;
   }
   public int GetBottom()
   {      
      return _bottom;
   }
   public int Setbottom(int top)
   {      
      return _bottom;
   }
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // It is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // It will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }


   
    
      


}

