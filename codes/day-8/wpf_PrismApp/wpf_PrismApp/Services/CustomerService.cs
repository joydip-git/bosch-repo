using System.Collections.Generic;

namespace wpf_PrismApp.Services
{
    public class CustomerService : ICustomerService
    {
        public List<string> GetAll()
        {
            return new List<string> { "Anil", "Sunil" };
        }
    }
}
