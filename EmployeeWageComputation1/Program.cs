namespace EmployeeWageComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emplployeewage computation program");
            // UC 5 CalculateWageForMonth
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int MAX_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0;
            Random myObj = new Random();
            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int empAttendence = myObj.Next(0, 3);
                switch (empAttendence)
                {
                    case FULL_TIME:
                        Console.WriteLine("Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day {0} Employeewage: {1}", day, empWage);
                totalWage += empWage;
            }
            Console.WriteLine("Total Employeewage for {0} days: {1}", (day - 1), totalWage);
            Console.ReadLine();
        }
    }

}



