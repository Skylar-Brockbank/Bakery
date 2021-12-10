using System.Collections.Generic;

namespace BakeryObjects
{
  public class Bread
  {
    public static int breadCounter;

    public Bread(int quantity)
    {
      breadCounter += quantity;
    }
    public static void resetValues()
    {
      breadCounter = 0;
    }
  }
  public class Pastry
  {
    public static int pastryCounter;
    public Pastry(int quantity)
    {
      pastryCounter += quantity;
    }
    public static void resetValues()
    {
      pastryCounter = 0;
    }
  }
}