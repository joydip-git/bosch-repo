using CalculationLibrary;

namespace CalculationExtensionLibrary
{
    public static class CalculationExtension
    {
        public static int Multiply(this Calculation calc, int a, int b)
        {
            int res = calc.Add(a, b);
            return a * b * res;
        }
    }
}
