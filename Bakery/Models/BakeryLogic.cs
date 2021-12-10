using System.Collections.Generic;

namespace BakeryObjects
{
  public class Bread
  {
    public static int breadCounter;
    private static int breadPrice = 2;

    public Bread(int quantity)
    {
      breadCounter += quantity;
    }
    public static void resetValues()
    {
      breadCounter = 0;
    }
    public static int getPrice()
    {
      if(breadCounter>=3){
        return(breadCounter-((breadCounter-(breadCounter%3))/3))*breadPrice;
      }
      return breadPrice*breadCounter;
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