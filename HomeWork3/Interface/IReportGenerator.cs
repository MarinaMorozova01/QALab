using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork3
{
    interface IReportGenerator
    {
        public List<Employee> SortSalary (List<Employee> personList);
        public List<Employee> SortCompanyName(List<Employee> personList);

    }
}
