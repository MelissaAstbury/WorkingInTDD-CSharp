namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public FizzBuzzCalculator()
        {

        }

        public string PrintString(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (num % 3 == 0 || num.ToString().Contains('3'))
            {
                return "Fizz";
            }

            if (num % 5 == 0)
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}