using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Hr : Employee
    {
        decimal gratuityPayment;

        public Hr()
        {

        }
        public Hr(string name, int id, decimal basicPay, decimal daPay, decimal hraPay, decimal gratuity, string project = null) : base(name, id, basicPay, daPay, hraPay, project)
        {           
            this.gratuityPayment = gratuity;
        }
    }
}
