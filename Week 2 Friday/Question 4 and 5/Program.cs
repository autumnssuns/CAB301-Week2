using System.ComponentModel;

namespace Question_4_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMinDistance(
                new double[] {
                0.1, 0.2, 0.5, 5, 3, 4, 9, 6, 5.7, 9.1
            }, 0.1, 0.0000000001);
        }

        static bool TestMinDistance
            (double[] input, double expectedResult, double tolerance)
        {
            double actualResult = MinDistance(input, out int counter);
            bool pass = Math.Abs(actualResult - expectedResult) < tolerance;
            Console.WriteLine(
                "Input: {0} => Expected: {1} | Actual {2}",
                input, expectedResult, actualResult);
            Console.WriteLine("{0} comparisons made", counter);
            Console.WriteLine(pass ? "PASS" : "FAIL");
            return pass;
        }

        /// <summary>
        /// Find the minimum distance between two numbers
        /// in an array
        /// </summary>
        /// <param name="A">The number array</param>
        /// <returns>The minimum distance between two numbers in the array</returns>
        static double MinDistance(double[] A, out int counter)
        {
            int n = A.Length;
            double dMin = double.MaxValue;
            //int c = 0;
            counter = 0;
            for (int i = 0; i <= n - 2; i++) // n times
            {
                //c = c + 1;
                for (int j = i + 1; j <= n - 1; j++) // 
                {
                    counter++; // Increment the counter for every comparison
                    if (Math.Abs(A[i] - A[j]) < dMin)
                    {
                        dMin = Math.Abs(A[i] - A[j]);
                    }
                }
            }
            return dMin;
        }

        /// <summary>
        /// Used to test a function that produces a double
        /// output
        /// </summary>
        /// <typeparam name="T">The input type</typeparam>
        /// <param name="func">The function to test</param>
        /// <param name="input">The input for the function to test</param>
        /// <param name="expectedResult">The expected output</param>
        /// <param name="tolerance">Defines how much the actual result
        /// can deviate from the expected result.</param>
        /// <returns>True if the test passed, false otherwise</returns>
        static bool TestFunctionDouble<T>(
            Func<T, double> func,
            T input,
            double expectedResult,
            double tolerance)
        {
            double actualResult = func(input);
            Console.WriteLine(
                "Input: {0}, Expected {1} | Actual {2}",
                input, expectedResult, actualResult);
            bool pass = Math.Abs(expectedResult - actualResult) < tolerance;
            Console.WriteLine(pass ? "PASS" : "FAIL");
            return pass;
        }
    }
}