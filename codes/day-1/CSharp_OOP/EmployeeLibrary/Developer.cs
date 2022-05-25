using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Developer : Employee
    {
        decimal incentivePayment;

        public Developer()
        {
        }

        public Developer(string name, int id, decimal basicPay, decimal daPay, decimal hraPay, decimal incentive, string project = null) : base(name, id, basicPay, daPay, hraPay, project)
        {
            this.incentivePayment = incentive;
        }
        //public new void CalculateSalary()
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary += incentivePayment;
        }
    }
}
