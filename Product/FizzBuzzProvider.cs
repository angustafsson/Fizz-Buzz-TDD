using System.Text;

namespace Product
{
    public static class FizzBuzzProvider
    {
        public static string Generate(int number)
        {
            var str = new StringBuilder();
            for (var i = 1; i < number + 1; i++)
            {
                AddValueToString(i, str);
            }
            return str.ToString();
        }

        private static void AddValueToString(int i, StringBuilder str)
        {
            if (IsDivisibleByThree(i) && IsDivisibleByFive(i))
            {
                AddFizzBuzz(str);
            }
            else if (IsDivisibleByThree(i))
            {
                AddFizz(str);
            }
            else if (IsDivisibleByFive(i))
            {
                AddBuzz(str);
            }
            else
            {
                AddNumber(str, i);
            }
        }

        private static void AddNumber(StringBuilder str, int i)
        {
            str.AppendFormat("{0} ", i);
        }

        private static void AddFizzBuzz(StringBuilder str)
        {
            str.Append("fizzbuzz ");
        }

        private static void AddFizz(StringBuilder str)
        {
            str.Append("fizz ");
        }

        private static void AddBuzz(StringBuilder str)
        {
            str.Append("buzz ");
        }

        private static bool IsDivisibleByThree(int i)
        {
            return i%3 == 0;
        }

        private static bool IsDivisibleByFive(int i)
        {
            return i%5 == 0;
        }
    }
}
