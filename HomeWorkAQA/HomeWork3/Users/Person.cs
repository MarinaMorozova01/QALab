using System;

namespace HomeWork3
{
    class Person : IDisplayable
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
        public string JobTitle;
        public string JobDescription;
        public decimal JobSalary;

        public Person()
        {
            // Exercise 4.
            Id = Guid.NewGuid();
            FirstName = new Bogus.DataSets.Name().FirstName();
            LastName = new Bogus.DataSets.Name().LastName();
            JobTitle = new Bogus.DataSets.Name().JobType();
            JobDescription = new Bogus.DataSets.Name().JobTitle();
            JobSalary = new Bogus.Randomizer().Int(500, 10000);
        }

        public  string FullName => $"{FirstName} {LastName}";

        public virtual void GetInfo()
        {
            Console.WriteLine("GetInfo in base class");
        }
    }
}
