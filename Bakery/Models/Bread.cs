using System;

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
    public void TotalBreadPrice()
    {
      Price = (Price * NumberOfLoaves);
    }
    // public void BreadDeal()
    // {
    //   int freeLoaves = NumberOfLoaves / 2; 
    //   NumberOfLoaves += freeLoaves;
    // }
  }
}