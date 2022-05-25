namespace DOTNET.BOSCH.EMS.BusinessEntities
{
    /// <summary>
    /// Employee entity
    /// </summary>
    public class Employee
    {
        #region Data Members
        string name;
        readonly int id;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal totalSalary;
        static decimal joiningBonus;
        #endregion

        #region Constructors
        /// <summary>
        /// static constructor initializing value to joining bonus
        /// </summary>
        static Employee() { joiningBonus = 10000; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee() { }

        /// <summary>
        /// parameterized constructor 
        /// </summary>
        /// <param name="name">name of an employee</param>
        /// <param name="id">id of an employee</param>
        /// <param name="basicPay">basic payment of an employee</param>
        /// <param name="daPay">da payment of an employee</param>
        /// <param name="hraPay">hra payment of an employee</param>
        public Employee(string name, int id, decimal basicPay, decimal daPay, decimal hraPay)
        {
            this.name = name;
            this.id = id;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
        }

        #endregion

        #region Properties

        /// <summary>
        /// sets of gets the name of an employee
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// gets the id of an employee
        /// </summary>
        public int Id => this.id;
        /// <summary>
        /// sets of gets the basic payment of an employee
        /// </summary>
        public decimal BasicPay { get => basicPay; set => basicPay = value; }
        /// <summary>
        /// sets of gets the da payment of an employee
        /// </summary>
        public decimal DaPay { get => daPay; set => daPay = value; }
        /// <summary>
        /// sets of gets the hra payment of an employee
        /// </summary>
        public decimal HraPay { get => hraPay; set => hraPay = value; }
        /// <summary>
        /// gets the joining bonus payment of an employee
        /// </summary>
        public static decimal JoiningBonus => joiningBonus;
        /// <summary>
        /// sets of gets the calculated total salary of an employee
        /// </summary>
        public decimal TotalSalary { get => totalSalary; }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate the total salary of an employee
        /// </summary>
        public void CalculateSalary()
        {
            this.totalSalary = this.basicPay + this.daPay + this.hraPay + joiningBonus;
        }
        #endregion
    }
}
