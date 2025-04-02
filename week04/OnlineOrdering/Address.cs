using System;
//contains a string for the street, the city, the city, state/province, and country. A method that returns whether it is in the USA or not. Also, have a method that returns a string with the address in an apporpiate layout.
//
public class Address
{
   private string _street;
   private string _city;
   private string _state;
   private string _country;

   //+++++++++++++  constructor  +++++++++++++++
   public Address(string street, string city, string state, string country)
   {
      _street = street;
      _city = city;
      _state = state;
      _country = country;
   }

   //+++++++++++++  methods  +++++++++++++++
   public bool LiveInUSA()
   {
     return _country.ToUpper() == "USA";
   }

   public string DisplayAdress()
   {
      return $"  {_street}\n  {_city} {_state}, {_country}";
   }
}