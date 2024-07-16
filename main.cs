using System;

class Program {
  public static void Main (string[] args) 
  {
  do
    {
    Intro(); // excecutes the Intro method 

    Comp Comp1 = new Comp(); // creating variables for the number of contestants to be compared
     Comp1.lastYear = 679;
     Comp1.thisYear = 252;

   var input = Console.ReadLine(); // takes the input from the user
      if (input == "1")
      {
        Console.WriteLine("\nThe number of contestants in the last year is " + Comp1.lastYear + " and the number of contestants in this year is " + Comp1.thisYear + ".");
        Console.WriteLine("This year's expected revenue is $" + (Comp1.thisYear * 25));

        if(Comp1.thisYear > (2 * Comp1.lastYear))
          {
            Console.WriteLine("The competition is more than twice as big as last years!");
          }
        else if (Comp1.thisYear > Comp1.lastYear)
          {
            Console.WriteLine("The competition is bigger than ever!");
          }
        else {
          Console.WriteLine("A tighter race this year! Come out and cast your vote!");
          }
        continue;

      }
      else if (input == "2")
        {
          Console.WriteLine("Thank you for using the Greenville Revenue App!");
          break;
        }
      else
        {
          Console.WriteLine("invalid input. Please try again");
          continue;
        }


  }while(true);
    }
  // end of main







  public static void Intro() //method for introduction
  {
    Console.WriteLine("\n*************************************");
    Console.WriteLine("*   The Stars Shine In Greenville   *");
    Console.WriteLine("*************************************\n");
    Console.WriteLine("Please enter the following number below from the following menu:\n");
    Console.WriteLine("1.  CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2.  Exit");
  }
  class Comp
  {
    public int lastYear;
    public int thisYear;
  }


}