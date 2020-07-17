using System;
using Bakery.Models;

public class Program
{
  private static string _orderName;
  private int _loavesOrder;
  private int _pastriesOrder;
  private int _orderPrice;
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
  public void AddExtraLoaves()
  {
    int freeLoaves = (_loavesOrder / 2); 
    _loavesOrder += freeLoaves;
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
    Console.WriteLine("Number of Loaves: " + _loavesOrder + " (Your extra loaves will be added at checkout.)");
    Console.WriteLine("Number of Pastries: " + _pastriesOrder);
    Console.WriteLine("Total: $" + _orderPrice);
    Console.WriteLine("Would you like to add anything to your order? [Enter 'Y' for 'Yes', any other key for 'No']");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      OrderBread();
      OrderPastries();
      DisplayOrder();
    }
    else
    {
      AddExtraLoaves();
      DisplayOrder();
      Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
    }
  }

  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! [Press 'Enter' to continue]");
    Console.ReadLine();
    Console.WriteLine("Today we have loaves of bread and pastries available.");
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


// using System;
// using Bakery.Models;

// public class Order
// {
//   public string OrderName { get; set; }
//   public int TotalLoaves { get; set; }
//   public int TotalPastries { get; set; }
//   public int OrderPrice { get; set; }
//   public Order(string orderName, int totalLoaves, int totalPastries, int orderPrice)
//   {
//     OrderName = orderName;
//     TotalLoaves = totalLoaves;
//     TotalPastries = totalPastries;
//     OrderPrice = orderPrice;
//   }
//   public void OrderBread()
//   {
//     Console.WriteLine("How many loaves of bread would you like to order, " + OrderName + "?");
//     string stringLoaves = Console.ReadLine();
//     int numberOfLoaves = int.Parse(stringLoaves);
//     Bread userBreadOrder = new Bread(numberOfLoaves); 
//     userBreadOrder.TotalBreadPrice();
//     userBreadOrder.BreadDeal();
//     TotalLoaves += userBreadOrder.NumberOfLoaves;
//     OrderPrice += userBreadOrder.Price;
//   }
//   public void OrderPastries()
//   {
//     Console.WriteLine("How many pastries would you like to order, " + OrderName + "?");
//     string stringPastries = Console.ReadLine();
//     int numberOfPastries = int.Parse(stringPastries);
//     Pastry userPastryOrder = new Pastry(numberOfPastries);
//     userPastryOrder.TotalPastryPrice();
//     TotalPastries += userPastryOrder.NumberOfPastries;
//     OrderPrice += userPastryOrder.Price;
//   }
//   public void DisplayOrder()
//   {
//     Console.WriteLine("~ " + OrderName + "'s Order ~");
//     Console.WriteLine("Number of Loaves: " + TotalLoaves);
//     Console.WriteLine("Number of Pastries: " + TotalPastries);
//     Console.WriteLine("Total: $" + OrderPrice);
//     Console.WriteLine("Would you like to add anything to your order? [Enter 'Y' for 'Yes', any other key for 'No']");
//     string answer = Console.ReadLine();
//     if (answer == "Y" || answer == "y")
//     {
//       OrderBread();
//       OrderPastries();
//       DisplayOrder();
//     }
//     else
//     {
//       Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
//     }
//   }
//   public static void Main()
//   {
//     Console.WriteLine("Welcome to Pierre's Bakery! Today we have loaves of bread and pastries for sale. [Press 'Enter' to continue]");
//     Console.ReadLine();
//     Console.WriteLine("Loaves of bread cost $5 each, and pastries cost $2 each.");
//     Console.ReadLine();
//     Console.WriteLine("Pierre's offers the following deals:");
//     Console.ReadLine();
//     Console.WriteLine("Loaves: Buy 2, Get One Free");
//     Console.WriteLine("Pastries: 3 for $5");
//     Console.ReadLine();

//     Console.WriteLine("So, would you like to place an order? [Enter 'Y' for 'Yes', any other key for 'No']");
//     string answer = Console.ReadLine();
//     if (answer == "Y" || answer == "y")
//     {
//       Console.WriteLine("Please enter an order name.");
//       string orderName = Console.ReadLine();
//       Order newOrder = new Order(orderName, 0, 0, 0);
//       newOrder.OrderBread();
//       newOrder.OrderPastries();
//       newOrder.DisplayOrder();
//     }
//     else
//     {
//       Console.WriteLine("Goodbye!");
//     }
//   }
// }