///
/// Created by Jesus 'Pokoidev' Villar, jesusferminvillar@gmail.com (www.pokoidev.com) 
/// Copyright © 2019 Pokoidev. Creative Commons License:
/// Attribution 4.0 International (CC BY 4.0)
///

using System.Collections.Generic;

namespace project_euler_c_sharp_solutions
{
    static class problem_001
    { 
        /// <summary>
        /// Problem 001: Multiples of 3 and 5 (https://projecteuler.net/problem=1)
        /// </summary>
        /// <returns> The sum of all the multiples of 3 or 5 below 1000</returns>
        public static int solution()
        {   
            //Max range of nums
            const int MAXNUMBER = 1000;

            //The factors of multiple nums
            List<int> factors = new List<int> { 3, 5 };
            
            int sum = 0;
            foreach (int factor in factors) for (var iterator = 0; iterator * factor <= MAXNUMBER; iterator++, sum += iterator * factor) ;
            
            return sum;
        }

    }
}
