using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    class Program
    {
        #region Exercise 3
        static List<Employee> SetRandomEmployee()
        {
            Random random = new Random();

            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                Employee employee = new Employee();
                listEmployee.Add(employee);
            }

            return listEmployee;
        }
        static List<Candidate> SetRandomCandidate()
        {
            Random random = new Random();

            List<Candidate> listCandidate = new List<Candidate>();

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                Candidate person = new Candidate();
                listCandidate.Add(person);
            }

            return listCandidate;
        }
        #endregion

        static void Main(string[] args)
        {
            var createPerson = new UserFactory();
            var candidate = createPerson.CreatePerson<Candidate>();
            var employee = createPerson.CreatePerson<Employee>();



            #region Exercise 6
            //List<Candidate> candidateList = SetRandomCandidate();
            //var candidateSort = new CandidateReportGenerator();
            //candidateList = candidateSort.SortSalary(candidateList);
            //candidateList = candidateSort.SortTitle(candidateList);

            //List<Employee> employeeList = SetRandomEmployee();
            //var employeeSort = new EmployeeReportGenerator();
            //employeeList = employeeSort.SortSalary(employeeList);
            //employeeList = employeeSort.SortNameCompany(employeeList);
            #endregion

        }
    }
}
