using System;

namespace EmployeeWages
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage System");
            DailyEmployeeWage employee = new DailyEmployeeWage();
            AddPartTimeEmployee partTime = new AddPartTimeEmployee();
            EmployeeWagesSwitchCase SCEmployeeWage = new EmployeeWagesSwitchCase();
            //Constants
            int Is_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            
            employee.Wages();
            partTime.ExtraTime();
            SCEmployeeWage.EWSwitch();
            Console.ReadLine();
        }
    }
}
