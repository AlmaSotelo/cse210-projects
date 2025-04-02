using System.Net.Sockets;
//contains the name (type string) and address (type Address) of the customer. Thorugh a method returns whether they live in the USA or not.
public class Customer
{
   string _customerName;
   private Address _address;

   //+++++++++++++ constructor +++++++++++++   
   public Customer(string customerName, Address address)
   {
      _customerName = customerName;
      _address = address;
   }

   //+++++++++++++ method +++++++++++++
   public bool IsAddressInUSA() 
   {
      return _address.LiveInUSA();
   }

   //+++++++++ getters/setters (accessors/mutators) ++++++++++
   public string GetCustomerInfo()
   {
      return $" {_customerName}\n{_address.DisplayAdress()}";
   }
}