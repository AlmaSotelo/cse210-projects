using System;
//contains the product name, Id, price, and quantity of each product. Computes the TotalCost.
public class Product
{
   //++++++++ attributes (member variables)
   private string _productName;
   private string _productId;
   private double _productPrice;
   private int _quantity;

   //+++++++++ constructor ++++++++++
   public Product(string productName, string productId, double productPrice, int quantity)
   {
      _productName = productName;
      _productId = productId;
      _productPrice = productPrice;
      _quantity = quantity;      
   }

   //+++++++++ methods (member functions) ++++++++++
   //no need of private methods
   public double TotalCost()
   {
      return _productPrice *_quantity;
   }

   //+++++++++ getters/setters (accessors/mutators) ++++++++++
   public string GetProductInfo()
   {
      //Ex. 3 laptops-G567U23
      return $" {_quantity,-2} {_productName,-25} {_productId}";
   }

}