using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int NumberOfLoaves { get; set; }
    public Bread(int numberOfLoaves)
    {
      Price = 5;
      NumberOfLoaves = numberOfLoaves;
    }

    public int TotalBreadPrice()
    {
      int totalBreadPrice = 0;
      totalBreadPrice += (Price * NumberOfLoaves);
      return totalBreadPrice;
    }
  }
}