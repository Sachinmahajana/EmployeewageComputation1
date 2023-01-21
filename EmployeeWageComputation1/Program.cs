namespace EmployeeWageComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emplployeewage computation program");
            // UC 3 EmployeeWageAddparttime
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            Random myObj = new Random();
            int empAttendence = myObj.Next(0,3);
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empAttendence == PART_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employeewage {0} wage", empWage);
            Console.ReadLine();
        }
     }
}





