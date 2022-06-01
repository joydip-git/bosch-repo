using System;

namespace CalculationLibray
{
    public class Calculation
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
