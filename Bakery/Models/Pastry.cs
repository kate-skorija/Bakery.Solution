using System;

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
    public void TotalPastryPrice()
    {
      Price = (Price * NumberOfPastries);
      int pastryDeal = (NumberOfPastries / 3);
      if (pastryDeal >= 1)
      {
        Price -= pastryDeal;
      }
    }
  }
}