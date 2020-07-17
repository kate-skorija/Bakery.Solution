using System;
using Bakery.Models;

public class Program
{
  private static string _orderName;
  private static int _loavesOrder;
  private static int _pastriesOrder;
  private static int _orderPrice;
  public void OrderBread()
  {
    Console.WriteLine("How many loaves of bread would you like to order, " + _orderName + "?");
    string stringLoaves = Console.ReadLine();
    int numberOfLoaves = int.Parse(stringLoaves);
    Bread userBreadOrder = new Bread(numberOfLoaves); 
    userBreadOrder.TotalBreadPrice();
    _loavesOrder += userBreadOrder.NumberOfLoaves;
    _orderPrice += userBreadOrder.Price;
  }
  public void OrderPastries()
  {
    Console.WriteLine("How many pastries would you like to order, " + _orderName + "?");
    string stringPastries = Console.ReadLine();
    int numberOfPastries = int.Parse(stringPastries);
    Pastry userPastryOrder = new Pastry(numberOfPastries);
    userPastryOrder.TotalPastryPrice();
    _pastriesOrder += userPastryOrder.NumberOfPastries;
    _orderPrice += userPastryOrder.Price;
  }
  public void DisplayOrder()
  {
    Console.WriteLine("~ " + _orderName + "'s Order ~");
    Console.WriteLine("Number of Loaves: " + _loavesOrder);
    Console.WriteLine("Number of Pastries: " + _pastriesOrder);
    Console.WriteLine("Total: $" + _orderPrice);
    AddToOrder();
  }
  public void AddExtraLoaves()
  {
    int freeLoaves = (_loavesOrder / 2); 
    _loavesOrder += freeLoaves;
  }
  public void AddToOrder()
  {
    Console.WriteLine("Would you like to add anything to your order? (Your extra loaves will be added at checkout.) [Enter 'Y' for 'Yes', any other key for 'No']");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      OrderBread();
      OrderPastries();
      AddExtraLoaves();
    }
      AddExtraLoaves();
      Console.WriteLine("~ " + _orderName + "'s Final Order ~");
      Console.WriteLine("Number of Loaves (with deal): " + _loavesOrder);
      Console.WriteLine("Number of Pastries: " + _pastriesOrder);
      Console.WriteLine("Total: $" + _orderPrice);
      Console.WriteLine("Order Complete! Thank you for shopping at Pierre's Bakery.");
  }
  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("Welcome to Pierre's Bakery! [Press 'Enter' to continue]");
    Console.ReadLine();
    Console.WriteLine("Today we are offering loaves of garlic bread and blueberry pastries.");
    Console.ReadLine();
    Console.WriteLine("Loaves of bread cost $5 each, and pastries cost $2 each.");
    Console.ReadLine();
    Console.WriteLine("Pierre's offers the following deals:");
    Console.ReadLine();
    Console.WriteLine("Loaves: Buy 2, Get One Free");
    Console.WriteLine("Pastries: 3 for $5");
    Console.ReadLine();

    Console.WriteLine("So, would you like to place an order? [Enter 'Y' for 'Yes', any other key for 'No']");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Program newOrder = new Program();
      Console.WriteLine("Please enter an order name.");
      _orderName = Console.ReadLine();
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