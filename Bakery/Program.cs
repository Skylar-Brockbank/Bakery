using System;
using BakeryObjects;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("$$\\      $$\\           $$\\                                             $$\\ ");
      Console.WriteLine("$$ | $\\  $$ |          $$ |                                            $$ |");
      Console.WriteLine("$$ |$$$\\ $$ | $$$$$$\\  $$ | $$$$$$$\\  $$$$$$\\  $$$$$$\\$$$$\\   $$$$$$\\  $$ |");
      Console.WriteLine("$$ $$ $$\\$$ |$$  __$$\\ $$ |$$  _____|$$  __$$\\ $$  _$$  _$$\\ $$  __$$\\ $$ |");
      Console.WriteLine("$$$$  _$$$$ |$$$$$$$$ |$$ |$$ /      $$ /  $$ |$$ / $$ / $$ |$$$$$$$$ |\\__|");
      Console.WriteLine("$$$  / \\$$$ |$$   ____|$$ |$$ |      $$ |  $$ |$$ | $$ | $$ |$$   ____|    ");
      Console.WriteLine("$$  /   \\$$ |\\$$$$$$$\\ $$ |\\$$$$$$$\\ \\$$$$$$  |$$ | $$ | $$ |\\$$$$$$$\\ $$\\ ");
      Console.WriteLine("\\__/     \\__| \\_______|\\__| \\_______| \\______/ \\__| \\__| \\__| \\_______|\\__|");
      Console.WriteLine("===========================================================================");
      Console.WriteLine(" ");
      Console.WriteLine("1.) View Menu Items");
      Console.WriteLine("2.) Checkout");
      Console.WriteLine(" ");
      Console.WriteLine("===========================================================================");
      string userInput = Console.ReadLine();
      Console.WriteLine("__________________");
      if(userInput == "1")
      {
        addItems();
      } else if(userInput == "2")
      {
        //Checkout Interface
        checkOut();
      }else{
        Console.WriteLine("I'm sorry to say, that's not a valid option");
        Main();
      }
    }
    public static void addItems(){
      Console.Clear();
      //offer all the things you can buy and ask for a quantity
      Console.WriteLine("1.) Bread " + Bread.breadPrice + "$/loaf");
      Console.WriteLine("2.) Pastry (they start at 2$/Pastry, but you get a bulk discount, at an inconsistent rate... good luck)");
      string userChoice = Console.ReadLine();
      Console.WriteLine("__________________");
      string interactiveText = "pastries";
      if(userChoice!="1"&&userChoice!="2")
      {
        Console.WriteLine("Sorry, That's not a valid choice");
        addItems();
      }
      if(userChoice == "1"){
        interactiveText = "loaves of bread";
      }
      Console.WriteLine("How many " + interactiveText + " would you like?");
      int quantity = int.Parse(Console.ReadLine());
      Console.WriteLine("__________________");
      if(userChoice == "1")
      {
        new Bread(quantity);
      }else{
        new Pastry(quantity);
      }
      Console.WriteLine(quantity + " " + interactiveText + " have been added to your cart");
      Console.WriteLine("Would you like to add any additional Items? (y/n)");
      string continueChoice = Console.ReadLine();
      Console.WriteLine("__________________");
      if(continueChoice.ToUpper() == "Y"){
        addItems();
      }else if(continueChoice.ToUpper() == "N"){
        Main();
      }else{
        Console.WriteLine("I'm sorry \"" + continueChoice + "\" is not a valid option");
        Console.WriteLine("press any key to be taken to the main menue");
        Console.ReadKey();
        Main();
      }
    }
    public static void checkOut()
    {
      Console.Clear();
      //get prices for each item
      int totalBreadCost = Bread.getPrice();
      int totalPastryCost = Pastry.getPrice();
      int totalCost = totalBreadCost+totalPastryCost;
      //list items with their prices
      if(Bread.breadCounter>0){
        Console.WriteLine(Bread.breadCounter + "X Bread $" + totalBreadCost);
      }
      if(Pastry.pastryCounter>0){
        Console.WriteLine(Pastry.pastryCounter + "X Pastry $" + totalPastryCost);
      }
      if(Bread.breadCounter<1 && Pastry.pastryCounter<1){
        Console.WriteLine("There's nothing in your cart");
      }else{
        Console.WriteLine("=======================");
        Console.WriteLine((Bread.breadCounter+Pastry.pastryCounter) +" Items Total: $" + totalCost);
      }

      Console.WriteLine(" ");
      //Console.WriteLine("_____________");
      Console.WriteLine("press any key to continue");
      Console.ReadKey();
      Bread.resetValues();
      Pastry.resetValues();
      
      Main();
      //list total
      //clear vairables
    }
  }
}