using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]

    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzer_GivenInt1_ReturnsString1()
        {
            int input = 1;
            string expected = "1";

            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

