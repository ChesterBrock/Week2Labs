/// week No. 2 Lab No. 1
/// File Name: Lab1.java
/// @author: Chester Brock
/// Date:  August 31, 2021
///
/// Problem Statement: Modify the MyFirstProgram.cs file so that it adds 
/// three integers instead of two. Store the sum of the three numbers
/// in a variable. Compile the program so that you receive no compiler 
/// error messages and then run it.
/// 
/// 
/// Overall Plan:
/// 1) Modify the myfirstproejct so that it accepts three numbers instead of two 
/// 2) Modify it so that it also mulitiply's the three numbers 
/// 3) now divide the sum with the product
/// 4) output the results.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add, multiply and divide three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter, then the third followed by enter: ");

            // declare two integer variables
            int n1, n2, n3, sum, product;
            double division;
            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());
            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            division = product / (double)sum;


            // print a message along with the sum of the two numbers
            Console.WriteLine(" The sum of the three numbers is: " + sum);
            Console.WriteLine(" The product of the three numbers is: " + product);
            Console.WriteLine(" The division of the sum and product is: " + division);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}
