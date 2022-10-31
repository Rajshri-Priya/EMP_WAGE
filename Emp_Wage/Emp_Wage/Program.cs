using System;
namespace Emp_wage
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATING DAILY WAGES");
            int IS_PRESENT = 1;
            int empHr = 0;
            int empRatePerHr = 20;
            int totalSalary = 0;
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                //computation
                int empCheck = random.Next(0, 2);

                if (empCheck == IS_PRESENT)
                {
                    Console.WriteLine("Employe is Present");
                    int empCheckFull = random.Next(0, 2);

                    switch (empCheckFull)
                    {
                        case 1:
                            Console.WriteLine("present for fullday");
                            empHr = 8;
                            break;
                        default:
                            Console.WriteLine("Present for half day");
                            empHr = 4;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Employe is Absent");
                }
                int salary = (empHr * empRatePerHr);
                Console.WriteLine("Employe salary :" + salary);
                totalSalary = totalSalary + salary;
            }
            Console.WriteLine("Employe Totalsalary :" + totalSalary);
        }
        
    }
}