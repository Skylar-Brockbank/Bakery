using System.Collections.Generic;

namespace BakeryObjects
{
  public class Bread
  {
    public static int breadCounter { get; set; }
    public static int breadPrice { get; set; } = 5;
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
    public static int getPrice()
    {
      if(pastryCounter<1){
        return 0;
      }
      if(pastryCounter==6)
      {
        return 10;
      }else if(pastryCounter==1){
        return 2;
      }
      return (pastryCounter+(pastryCounter-1));
    }
  }
}