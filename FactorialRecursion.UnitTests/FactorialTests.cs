using NUnit.Framework;

namespace FactorialRecursion.UnitTests
{
    public class Tests
    {

        private Factorial factorialRecursion;

        [SetUp]
        public void Setup()
        {
            factorialRecursion = new Factorial();
        }

        [Test]
        public void GivenARecursion_WhenValueIsZero_ThenReturnZero()
        {
            var result = factorialRecursion.Calculate(0);

            Assert.AreEqual(0, result);
        }        
        
        [Test]
        public void GivenARecursion_WhenValueIsPositive_ThenCalculateIt()
        {
            var result = factorialRecursion.Calculate(5);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenARecursion_WhenValueIsNegative_ThenReturnZero()
        {
            var result = factorialRecursion.Calculate(-13);

            Assert.AreEqual(0, result);
        }
    }
}