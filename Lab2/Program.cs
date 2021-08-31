/// week No. 2 Lab No. 2
/// File Name: Lab2.java
/// @author: Chester Brock
/// Date:  August 31, 2021
///
/// Problem Statement: Write a program that defines a variable initially assigned 
/// to the number of coupons you win
/// 
/// 
/// Overall Plan:
/// 1) Define variables for the number of coupons,number of gumballs and number of candy bars
/// 2) also define coupons after candy bars and coupons after gumballs.
/// 3) find the numebr of candybars by dividing coupons by 10
/// 4) calculate the remaining coupons
/// 5) calculate the gumballs
/// 6) calculate and leftovers coupons 
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			int numCoupons = 108;
			int numCouponsAfterCandyBars, numCouponsAfterGumBalls, numCandyBars, numGumBalls;
			// integer division 
			numCandyBars = numCoupons / 10;
			// calculate the remaining coupons
			numCouponsAfterCandyBars = numCoupons % 10;

			// calculate gumboils
			numGumBalls = numCouponsAfterCandyBars / 3;

			//calculate any leftover coupons
			numCouponsAfterGumBalls = numCouponsAfterCandyBars % 3;

			// displaying the results 
			Console.WriteLine("Your {0} coupons can be redeemed for {1} candy bars and {2} gumballs with {3} coupons leftover ", numCoupons, numCandyBars, numGumBalls, numCouponsAfterGumBalls);

			Console.ReadLine();
		}
    }
}
