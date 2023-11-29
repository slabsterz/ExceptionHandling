using System;

namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int ReadNumber(int start, int end)
            {
                int input = int.Parse(Console.ReadLine());

                if (input <= start || input >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return input;
            }

            int[] numbers = new int[10];
            int previousNum = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    int currentNum = ReadNumber(previousNum, 100);

                    if (currentNum > previousNum)
                    {
                        numbers[i] = currentNum;
                        previousNum = currentNum;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {previousNum} - 100!");
                    i--;
                }
                catch
                {
                    Console.WriteLine("Invalid Number!");
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
