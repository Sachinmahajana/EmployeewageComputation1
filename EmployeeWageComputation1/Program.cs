namespace EmployeeWageComputation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emplployeewage computation program");
            // UC 1 EmployeeAttendence
            int isPresent = 1;
            Random myObj = new Random();
            int empAttendence = myObj.Next(0, 2);

            if (empAttendence == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}