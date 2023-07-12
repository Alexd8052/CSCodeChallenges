namespace CodeChallenges2
{
    internal class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===== Fibonacci Even Sum ===== ");

            int sumOfEvenNums = 0;
            int value1 = 1;
            int value2 = 1;
            int temp = 0;

            while (value2 <= 4000000)
            {
                Console.WriteLine(value2);
                if (value2 % 2 == 0)
                {
                    sumOfEvenNums += value2;
                }
                temp = value2;
                value2 = value1 + value2;
                value1 = temp;
                
            }

            Console.WriteLine("The sum of the even-valued terms is: " + sumOfEvenNums);
        }
    }
}