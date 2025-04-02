using System;
//Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label.
public class Order
{
   private List<Product>_products;
   private Customer _customer;

   //+++++ constructor to set the initial values +++++

   public Order(Customer customer)
   {
      _customer = customer;
      _products = new List<Product>();
   }

   //+++++++++ methods +++++++++++

   public void AddProduct(Product product)
   {
      _products.Add(product);
   }

   //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost
   public double TotalPrice()
   {
      //sum of the total cost of each product
      double total = 0;
      foreach (Product product in _products)
      {
         total += product.TotalCost();
      }
      //plus a one-time shipping cost
      //if (_customer.IsAddressInUSA())
      //{
      //   total+= 5;  //why total is not seen?       
      //}
      total += _customer.IsAddressInUSA() ? 5 : 35;
      return total;
   }

   //A packing label should list the name and product id of each product in the order.
   public string MakePackingLabel()
   {
      string label = "";
      foreach (Product product in _products)
      {
         //add string of product info in a line each time that intirate.Note that label is type string, not a list.
         label += $" {product.GetProductInfo()}\n";
      }
      return $"Product Order Detail\n{label}";
   }
   //A shipping label should list the name and address of the customer
   public string MakeShippingLabel()
   {
      return $"Shipping Info\n {_customer.GetCustomerInfo()}";
   }  

}