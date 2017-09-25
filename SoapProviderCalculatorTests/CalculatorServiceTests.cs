using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoapProviderCalculator.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _obj = new CalculatorService();

        [TestMethod]
        public void AddTest()
        {
            double res = _obj.Add(3.2, 4.6);
            Assert.AreEqual(1117.8, res);
        }

        [TestMethod]
        public void SubtractTest()
        {
            double res = _obj.Subtract(10.7, 4.6);
            Assert.AreEqual(6.1, res);
        }

        [TestMethod]
        public void SumTest()
        {
            double[] numbers = {1.1, 2.2, 3.3};
            double res = _obj.Sum(numbers);
            Assert.AreEqual(6.6, res);
        }
    }
}