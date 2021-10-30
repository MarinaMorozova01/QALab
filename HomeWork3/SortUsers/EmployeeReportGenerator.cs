using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    class EmployeeReportGenerator : IReportGenerator
    {
        public List<Employee> SortSalary(List<Employee> employeeList)
        {
            var sortEmployee = employeeList.OrderByDescending(u => u.JobSalary).ToList();
            employeeList = sortEmployee;

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine($"{employeeList[i].Id} | {employeeList[i].CompanyName} |" +
                    $" {employeeList[i].FullName} | {employeeList[i].JobSalary}");
            }

            return employeeList;
        }

        public List<Employee> SortCompanyName(List<Employee> employeeList)
        {
            var sortEmployee = employeeList.OrderBy(u => u.CompanyName).ToList();
            employeeList = sortEmployee;

            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine($"{employeeList[i].Id} | {employeeList[i].CompanyName} |" +
                    $" {employeeList[i].FullName} | {employeeList[i].JobSalary}");
            }

            return employeeList;
        }       
    }
}
