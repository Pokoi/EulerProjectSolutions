///
/// Created by Jesus 'Pokoidev' Villar, jesusferminvillar@gmail.com (www.pokoidev.com) 
/// Copyright © 2019 Pokoidev. Creative Commons License:
/// Attribution 4.0 International (CC BY 4.0)
///

using System;

namespace project_euler_c_sharp_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"PROBLEM 1: The sum of all the multiples of 3 or 5 below 1000 is:  {problem_001.solution()}");
            Console.WriteLine($"PROBLEM 2: The sum of all the even-valued terms in the Fibonacci sequence below 4000000 is:  {problem_002.solution()}");
            Console.WriteLine($"PROBLEM 3: The largest prime factor of the number 600851475143 is: {problem_003.solution()}");
            Console.ReadLine();
        }
    }
}
