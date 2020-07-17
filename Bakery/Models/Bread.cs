using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public Bread(int price)
    {
      Price = price;
    }
  }
}