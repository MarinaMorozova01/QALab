using System;

namespace HomeWork3
{
    class Employee : Person
    {
        public string CompanyName;
        public string CompanyCountry;
        public string CompanyCity;
        public string CompanyAddress;

        public Employee()
        {
            // Exercise 4.
            CompanyName = new Bogus.DataSets.Company().CompanyName();
            CompanyCountry = new Bogus.DataSets.Address().Country();
            CompanyCity = new Bogus.DataSets.Address().City();
            CompanyAddress = new Bogus.DataSets.Address().FullAddress();
        }

        // Exercise 2.
        public override void GetInfo()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in {CompanyName} " +
                $"({ CompanyCountry}, {CompanyCity}, { CompanyAddress}) and mysalary { JobSalary}.");
        }
    }
}
