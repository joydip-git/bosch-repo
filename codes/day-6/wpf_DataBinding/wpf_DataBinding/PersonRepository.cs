﻿using System.Collections.Generic;

namespace wpf_DataBinding
{
    public static class PersonRepository
    {
        public static List<Person> People => new List<Person>
        {
            new Person{Id=1, Name="joy", Salary=1000},
            new Person{Id=3, Name="Mani", Salary=3000},
            new Person{Id=2, Name="Murali", Salary=2000}
        };
    }
}
