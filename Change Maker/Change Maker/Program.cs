using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the function Changemaker
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);

            //keep console open
            Console.ReadKey();

        }

        //creat a function changemaker that takes a dollar amount and gives 
        //the number of each type of coins
        static void ChangeMaker(double amount)
        {
            //declare variable to hold the input amount converted to integer
            //by multiplying 100
            int money = Convert.ToInt32(amount * 100);
            
            //declare variables to hold the number of each type of coin.
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            //print to console the original amount entered 
            Console.WriteLine("Amount: $" + amount);

          //  create a while loop to loop while money is greater than zero;
            while (money > 0)
            {   
                //first condition to check would be if money is greater than a
                //a quarter and if so subtract as many quarters as possible and
                //increment the variable quarter every time we subtract 25 untill money is
                //not greater than 25
               if(money >= 25)
               {
                   money -= 25;
                   quarters += 1;
               }
               //check this condition while money is greater than a dime, but less 
               //than a quarter, and increment the variable by one every time you subtract
               // 10 
               else if (money >= 10)
               {
                   money -= 10;
                   dimes += 1;
               }
                //check this condition while money is greater than a nickel, but less than dime
                // and increment nickel evertime 5 is subtracted from money
               else if (money >= 5)
               {
                   money -= 5;
                   nickels += 1;
               }
                //else if money is less than a nickel, take the value of money and put
                //them into the variable pennies, and subtract the remaining value from
                 // money, so it has zero left and we can get out of the loop.
               else
               {
                   pennies = money;
                   money -= money;

               }
          }
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennies);
            Console.WriteLine();
           
        }
    }
}
