namespace wpf_DataBinding
{
    public class Person
    {
        public Person(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public Person()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
