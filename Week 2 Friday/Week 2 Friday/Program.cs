namespace Week_2_Friday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestBinaryToDecimal("1011", 11);
            TestBinaryToDecimal("00001", 1);
            TestBinaryToDecimal("1", 1);
            TestBinaryToDecimal("11111111", 255);
        }

        static bool TestBinaryToDecimal
            (string input, int expectedResult)
        {
            int actualResult = BinaryToDecimal(input);
            bool pass = actualResult == expectedResult;
            Console.WriteLine(
                "Input: {0} => Expected: {1} | Actual {2}",
                input, expectedResult, actualResult);
            Console.WriteLine(pass ? "PASS" : "FAIL");
            return pass;
        }

        /// <summary>
        /// Convert the given binary string to a decimal number
        /// </summary>
        /// <param name="binaryString">A binary string of length n</param>
        /// <returns>The decimal representation of the number</returns>
        static int BinaryToDecimal
            (string binaryString)
        {
            int n = binaryString.Length;
            int total = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                int digit = int.Parse(binaryString[i].ToString());
                total += (int) Math.Pow(2, n - i - 1) * digit;
            }
            return total;
        }
    }
}