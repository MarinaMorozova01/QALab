using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    class CandidateReportGenerator
    {
        public List<Candidate> SortSalary(List<Candidate> candidateList)
        {
            candidateList = candidateList.OrderBy(u => u.JobSalary).ToList();

            for (int i = 0; i < candidateList.Count; i++)
            {
                Console.WriteLine($"{candidateList[i].Id} | {candidateList[i].JobTitle} |" +
                    $" {candidateList[i].FullName} | {candidateList[i].JobSalary}");
            }

            return candidateList;
        }

        public List<Candidate> SortTitle(List<Candidate> candidateList)
        {
            candidateList = candidateList.OrderBy(u => u.JobTitle).ToList();


            for (int i = 0; i < candidateList.Count; i++)
            {
                Console.WriteLine($"{candidateList[i].Id} | {candidateList[i].JobTitle} |" +
                    $" {candidateList[i].FullName} | {candidateList[i].JobSalary}");
            }

            return candidateList;
        }
    }
}
