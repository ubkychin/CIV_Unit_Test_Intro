using System;

namespace RecursiveCalculations {
    public class RecursiveCalculator {
        
        /// <summary>
        /// Returns the factorial for given input.  Initialise ans with 1
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ans"></param>
        /// <returns></returns>
        public int FactorialRec (int input, int ans = 1) {
            if (input == 0) {
                return ans;
            }

            ans = ans * input;
            return FactorialRec (input - 1, ans);
        }

        /// <summary>
        /// Checks if num is a Fibonacci Number.  Initialise num1 and num2 = 1;
        /// </summary>
        /// <param name="num"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public bool FibCheck (int num, int num1 = 1, int num2 = 1) {
            if (num == num1 || num == num2) {
                return true;
            }

            if (num < num2) {
                return false;
            }

            var tmp = num1;
            num1 = num2;
            num2 = tmp + num2;

            return FibCheck(num, num1, num2);
            
        }

        /// <summary>
        /// Check if num is a prime number.  Initialise divisor with 2
        /// </summary>
        /// <param name="num"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public bool PrimeCheckRec (int num, int divisor = 2) {
            if (num == divisor) {
                return true;
            }

            if (num > divisor) {
                return num % divisor != 0 && PrimeCheckRec (num, divisor + 1);
            }

            return false;
        }

        /// <summary>
        /// Returns the nth Fibonacci number
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="numFibs"></param>
        /// <returns></returns>
        public int FibonacciRec (int numFibs, int num1 = 1, int num2 = 1) {
            if (numFibs > 0) {
                numFibs--;
                num2 = num1 + num2;
                return FibonacciRec (numFibs, num2, num2 + num1);
            }
            return num2 + num1;
        }
    }
}