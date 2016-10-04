using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_10_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();  //This is the my new TimePeriod object called t

            t.Hours = 24;  //Object.Property 
            

            Console.WriteLine("One day in hours: " + t.Hours);



//Working with Customer class below****************************************

            Customer brad = new Customer(3873.87, "Brad", 1838298);

            
            
            
     //Modify a Customer property

            brad.TotalPurchases += 400.14;  //object.Property = total purchases plus whatever is being purchased now
            Console.WriteLine(brad.TotalPurchases);
            Console.ReadLine();



     //Created a city property which automatically got set to Mentor.  Call the object brad.NewField
            Console.WriteLine(brad.City);
            Console.ReadLine();


//Creating new Human object
            Human being = new Human();

            Console.WriteLine("Person Details: {0}", being);
            Console.ReadLine();


//Assign some values and print again
            being.Name = "Chuck";
            being.Age = 87;
            Console.WriteLine("Person Details: {0}", being);
            Console.ReadLine();

            being.Age += 1;
            Console.WriteLine("Person Details: {0}", being);
            Console.ReadLine();

            while(being.Age < 100)
            {
                Console.WriteLine(being.Name + ", " + being.Age);
                being.Age++;
            }


        }
    }
}
