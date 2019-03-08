///
/// Created by Jesus 'Pokoidev' Villar, jesusferminvillar@gmail.com (www.pokoidev.com) 
/// Copyright © 2019 Pokoidev. Creative Commons License:
/// Attribution 4.0 International (CC BY 4.0)
///

namespace project_euler_c_sharp_solutions
{
    static class problem_002
    {
        /// <summary>
        /// Problem 002: Even Fibonacci numbers (https://projecteuler.net/problem=2)
        /// </summary>
        /// <returns> The sum of all the even-valued terms in the Fibonacci sequence below 4000000</returns>
        public static int solution()
        {
            //Max range of nums
            const int MAXNUMBER = 4000000;

            //The factors of multiple nums
            int penultimate_number = 0, last_number = 1;

            int sum = 0;
            while (penultimate_number + last_number <= MAXNUMBER)
            {
                int new_number     = penultimate_number + last_number;
                penultimate_number = last_number;
                last_number        = new_number;
                sum += last_number % 2 == 0 ? last_number : 0;
            }  

            return sum;
        }
    }
}
