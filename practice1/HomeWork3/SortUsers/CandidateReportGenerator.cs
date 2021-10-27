using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork3
{
    class CandidateReportGenerator 
    {
        public List<Candidate> SortSalary(List<Candidate> candidateList)
        {
            var sortCandidate = candidateList.OrderBy(u => u.JobSalary).ToList();
            candidateList = sortCandidate;

            for (int i = 0; i < candidateList.Count; i++)
            {
                Console.WriteLine($"{candidateList[i].Id} | {candidateList[i].JobTitle} |" +
                    $" {candidateList[i].FullName} | {candidateList[i].JobSalary}");
            }


            return candidateList;
        }

        public List<Candidate> SortTitle(List<Candidate> candidateList)
        {
            var sortCandidate = candidateList.OrderBy(u => u.JobTitle).ToList();
            candidateList = sortCandidate;

            for (int i = 0; i < candidateList.Count; i++)
            {
                Console.WriteLine($"{candidateList[i].Id} | {candidateList[i].JobTitle} |" +
                    $" {candidateList[i].FullName} | {candidateList[i].JobSalary}");
            }

            return candidateList;
        }
    }
}
