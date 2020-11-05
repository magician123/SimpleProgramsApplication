using System.Collections.Generic;

namespace SimplePrograms.Logic
{
    public class ComputeNumbers
    {
        public int GetMax(int[] array)
        {
            int maxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
            }

            return maxNumber;

        }

        public int GetMin(int[] array)
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (minNumber > array[i])
                {
                    minNumber = array[i];
                }

            }

            return minNumber;

        }

        public List<int> Fibonacci(int length)
        {
            var numbers = new List<int>();
            int firstNumber = 0, secondNumber = 1, nextNumber;

            numbers.Add(firstNumber);
            numbers.Add(secondNumber);



            for (int i = 0; i < length; i++)
            {
                nextNumber = firstNumber + secondNumber;

                numbers.Add(nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;

            }

            return numbers;
        }

        public bool IsPrimeNumber(int inputNumber)
        {
            bool isPrime = true;

            for (int i = 2; i < inputNumber / 2; i++)
            {

                if (inputNumber % i == 0)
                    isPrime = false;   
            }

            return isPrime;
        }
    }
}
