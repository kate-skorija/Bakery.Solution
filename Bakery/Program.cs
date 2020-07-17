using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! Today we have loaves of bread and pastries for sale.");
    Console.WriteLine("Loaves of bread cost $5 each, and pastries cost $2 each.");
    Console.WriteLine("Pierre's offers the following deals:");
    Console.WriteLine("Loaves: Buy 2, Get One Free");
    Console.WriteLine("Pastries: 3 for $5");

    Console.WriteLine("How many loaves of bread would you like to order?");
    string stringLoaves = Console.ReadLine();
    int numberOfLoaves = int.Parse(stringLoaves);
    Bread userBreadOrder = new Bread(numberOfLoaves); 
    userBreadOrder.TotalBreadPrice();
    userBreadOrder.BreadDeal();

    Console.WriteLine("How many pastries would you like to order?");
    string stringPastries = Console.ReadLine();
    int numberOfPastries = int.Parse(stringPastries);
    Pastry userPastryOrder = new Pastry(numberOfPastries);
    userPastryOrder.TotalPastryPrice();

    Console.WriteLine("Number of Loaves: " + userBreadOrder.NumberOfLoaves);
    Console.WriteLine("Number of Pastries: " + userPastryOrder.NumberOfPastries);
    Console.WriteLine("Bread Price: " + userBreadOrder.Price);
    Console.WriteLine("Pastry Price: " + userPastryOrder.Price);
    int totalOrderPrice = (userBreadOrder.Price + userPastryOrder.Price);
    Console.WriteLine(totalOrderPrice);
  }
}