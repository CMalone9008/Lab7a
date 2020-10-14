using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
  
  int numCars;
  double numHours = 0;
  double pCharge = 2;
  double xCharge = .5;
  double maxCharge = 10;
  int maxHours = 24;
  
  

Console.WriteLine("Enter the number of cars:");
numCars = Convert.ToInt32(Console.ReadLine());

for (int counter = 1; counter <= numCars; counter++)
{
  Console.WriteLine("Enter the number of hours parked for car#" + counter);
  numHours = Convert.ToDouble(Console.ReadLine());
   
if (numHours <= 3)
{
  Console.WriteLine("Total amount charged is $" + pCharge * numHours);
 }
else if (numHours >= 3)
{
  Console.WriteLine("Total amount charged is $" +  (numHours - 3) * (pCharge + xCharge));
   }
else
{
  Console.WriteLine("Max charge of $" + maxCharge);
  }
}

Console.WriteLine("Are there anymore cars in the garage?");
Console.ReadLine();

   
   
   
   




   


   

 
 



 
    
  }
}