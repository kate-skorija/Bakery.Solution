using System;
using Bakery.Models;

public class Order
{
  public string OrderName { get; set; }
  public int TotalLoaves { get; set; }
  public int TotalPastries { get; set; }
  public int OrderPrice { get; set; }
  public Order(string orderName, int totalLoaves, int totalPastries, int orderPrice)
  {
    OrderName = orderName;
    TotalLoaves = totalLoaves;
    TotalPastries = totalPastries;
    OrderPrice = orderPrice;
  }
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! Today we have loaves of bread and pastries for sale.");
    Console.WriteLine("Loaves of bread cost $5 each, and pastries cost $2 each.");
    Console.WriteLine("Pierre's offers the following deals:");
    Console.WriteLine("Loaves: Buy 2, Get One Free");
    Console.WriteLine("Pastries: 3 for $5");

    Console.WriteLine("Would you like to place an order? [Enter 'Y' for 'Yes', 'N' for 'No']");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Please enter an order name.");
      string orderName = Console.ReadLine();
      Order newOrder = new Order(orderName, 0, 0, 0);
    }
    else
    {
      Console.WriteLine("Goodbye!");
    }
  }
}