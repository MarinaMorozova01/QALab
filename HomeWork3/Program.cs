using System;
using System.Collections.Generic;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var createPerson = new UserFactory();
            var candidate = createPerson.CreatePerson<Candidate>();
            var employee = createPerson.CreatePerson<Employee>();

            #region Exercise 6

            List<Candidate> candidateList = createPerson.SetRandomPerson<Candidate>();
            var candidateSort = new CandidateReportGenerator();

            candidateList = candidateSort.SortSalary(candidateList);
            candidateList = candidateSort.SortTitle(candidateList);

            List<Employee> employeeList = createPerson.SetRandomPerson<Employee>();
            var employeeSort = new EmployeeReportGenerator();

            employeeList = employeeSort.SortSalary(employeeList);
            employeeList = employeeSort.SortCompanyName(employeeList);

            #endregion

        }
    }
}
