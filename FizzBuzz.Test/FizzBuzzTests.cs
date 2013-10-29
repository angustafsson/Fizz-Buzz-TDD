using NUnit.Framework;
using Product;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, Result = "1 ")]
        [TestCase(2, Result = "1 2 ")]
        [TestCase(3, Result = "1 2 fizz ")]
        [TestCase(4, Result = "1 2 fizz 4 ")]
        [TestCase(5, Result = "1 2 fizz 4 buzz ")]
        [TestCase(15, Result = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz ")]
        public string FizzBuzz_PrintsRightNumber(int number)
        {
            return FizzBuzzProvider.Generate(number);
        }
    }
}
