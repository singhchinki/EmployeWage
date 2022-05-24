using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageCom
{
    internal class DailyWage
    {
        public void Dailywage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            //Predefined random class for generating random values
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Checking employee status" + empCheck);
            
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Daily employee wage is" + empWage);
            Console.ReadLine();
        }
    }
}
