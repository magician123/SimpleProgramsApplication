namespace SimplePrograms.Logic
{
    public class Factorial
    {
        public int FindFactorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * FindFactorial(number - 1);

        }

    }
}
