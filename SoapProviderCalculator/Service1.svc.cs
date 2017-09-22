using System.Linq;

namespace SoapProviderCalculator
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sum(double[] numbers)
        {
            return numbers.Sum();
        }
    }
}
