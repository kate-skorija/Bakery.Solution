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
  public void OrderBread()
  {
    Console.WriteLine("How many loaves of bread would you like to order?");
    string stringLoaves = Console.ReadLine();
    int numberOfLoaves = int.Parse(stringLoaves);
    Bread userBreadOrder = new Bread(numberOfLoaves); 
    userBreadOrder.TotalBreadPrice();
    userBreadOrder.BreadDeal();
    TotalLoaves += userBreadOrder.NumberOfLoaves;
    OrderPrice += userBreadOrder.Price;
  }
  public void OrderPastries()
  {
    Console.WriteLine("How many pastries would you like to order?");
    string stringPastries = Console.ReadLine();
    int numberOfPastries = int.Parse(stringPastries);
    Pastry userPastryOrder = new Pastry(numberOfPastries);
    userPastryOrder.TotalPastryPrice();
    TotalPastries += userPastryOrder.NumberOfPastries;
    OrderPrice += userPastryOrder.Price;
  }
  public void DisplayOrder()
  {
    Console.WriteLine(OrderName + "'s Order");
    Console.WriteLine("Number of Loaves: " + TotalLoaves);
    Console.WriteLine("Number of Pastries: " + TotalPastries);
    Console.WriteLine("Total: $" + OrderPrice);
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
      newOrder.OrderBread();
      newOrder.OrderPastries();
      newOrder.DisplayOrder();
    }
    else
    {
      Console.WriteLine("Goodbye!");
    }
  }
}