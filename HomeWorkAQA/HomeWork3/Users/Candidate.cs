using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    enum DismissalReasonEnum
    {
        FamilyReasons,
        ProfessionalGrowthLack,
        LowSalary,
        BadTeamMicroclimate,
        LackManagementUnderstanding,
        Other
    }

    class Candidate : Person
    {
        public string DismissalReason { get; set; }

        Random random = new Random();
        private int _checkValue;

        DismissalReasonEnum[] DismissalReasonArray = (DismissalReasonEnum[])Enum.GetValues(typeof(DismissalReasonEnum));

        public Candidate()
        {
            _checkValue = random.Next(2);
            if (_checkValue == 1)
            {
                DismissalReason = Convert.ToString(DismissalReasonArray[random.Next(DismissalReasonArray.Length)]);
            }
            else if (_checkValue == 0)
            {
                DismissalReason = null;
            }
        }

        // Exercise 2.
        public override void GetInfo()
        {
            if (DismissalReason != null)
            {
                Console.WriteLine($"Hello, I am {FullName}." +
                   $" I want to be a {JobTitle} ({JobDescription}) with a salary from { JobSalary}." +
                   $"I quit my previous job for a reason of {DismissalReason}.");
            }
            else if (DismissalReason == null)
            {
                Console.WriteLine($"Hello, I am {FullName}." +
                    $"I want to be a {JobTitle} ({JobDescription}) with a salary from { JobSalary}." +
                    $" I haven't worked anywhere before.");
            }
        }
    }
}
