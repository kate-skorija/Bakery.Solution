using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int NumberOfPastries { get; set; }

    public Pastry(int numberOfPastries)
    {
      Price = 2;
      NumberOfPastries = numberOfPastries;
    }
    public int TotalPastryPrice()
    {
      int totalPastryPrice = 0;
      totalPastryPrice += (Price * NumberOfPastries);
      return totalPastryPrice;
    }
  }
}