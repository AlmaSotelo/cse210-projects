using System.Diagnostics;
using System.Reflection.Metadata;
using System;
public class Shape
{
   //Step 3.2 Add the color member variable and a getter and setter for it.
   private string _color; 
      //As part of Step 4.3 we need to change from private to protected in order to have it accessible for contractor in Square.cs
     
   public string GetColor()
   {
      return _color;
   }
   public void SetColor(string color)
   {
      _color = color;
   }
   
   //Part 3.3 Create a constructor that accepts the color and set its.
   public Shape(string color)
   {
      _color = color;
   }
   //Step 3.4 Create a virtual method for GetArea().
   //this will need to be eliminated because each shape has its own way to calculate it area
   public virtual double GetArea()
   {
      return 0;
   }

   

}
