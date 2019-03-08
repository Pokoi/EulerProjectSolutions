///
/// Created by Jesus 'Pokoidev' Villar, jesusferminvillar@gmail.com (www.pokoidev.com) 
/// Copyright © 2019 Pokoidev. Creative Commons License:
/// Attribution 4.0 International (CC BY 4.0)
///

namespace project_euler_c_sharp_solutions
{
    static class problem_003
    {
        /// <summary>
        /// Problem 003: Largest prime factor (https://projecteuler.net/problem=3)
        /// </summary>
        /// <returns> The largest prime factor of the number 600851475143 </returns>
        public static int solution()
        {
            //The given number
            long number = 600851475143;
            int prime_factor = 2;         
           
            for (prime_factor = 2; number > 1; prime_factor += number > 1? 1 : 0) while (number % prime_factor == 0) number /= prime_factor;
            
            return prime_factor;
        }
    }
}
