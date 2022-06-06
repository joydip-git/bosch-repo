using System;
using System.Globalization;
using System.Windows.Controls;

namespace wpf_DataBinding.Validatiors
{
    public class SalaryValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string result = (string)value;
            double salary = 0;
            try
            {
                if (result.Length > 0)
                {
                    salary = double.Parse(result, NumberStyles.Any, cultureInfo);
                }
            }
            catch
            {
                return new ValidationResult(false, "illegal characters");
            }

            if (salary < 0)
                return new ValidationResult(false, "Salary can't be negative");
            else
                return new ValidationResult(true, null);
        }
    }
}
