using System;
using System.Collections.Generic;
using System.Text;

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

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public virtual void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
