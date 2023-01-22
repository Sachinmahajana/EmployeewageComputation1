namespace EmployeeWageComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emplployeewage computation program");
            // UC 6 CalculateWage for total Working Days total working hours
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;
            Random myObj = new Random();
            while(day<=MAX_WORKING_DAYS && totalHrs<=MAX_WORKING_HRS)
            {
                int empAttendence = myObj.Next(0, 3); //0 or 1 or 2
                switch (empAttendence)
                {
                    case FULL_TIME:
                        Console.WriteLine("\nFull Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("\nPart Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day {0} Employeewage: {1} totalHrs:{2}", day, empWage,totalHrs);
                totalWage += empWage;
                day++;
                totalHrs += empHrs;
            }
            Console.WriteLine("Total Employeewage for {0} days: {1} and totalHrs:{2}", (day - 1), totalWage, totalHrs);
            Console.ReadLine();
        }
    }

}



