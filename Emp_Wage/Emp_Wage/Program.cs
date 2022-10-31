using System;
namespace Emp_wage
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATING DAILY ATTENDENCE");
            int IS_PRESENT = 1;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employes is Present");
            }
            else
            {
                Console.WriteLine("Employe is Absent");
                Console.ReadLine();
            }
        }
        
    }
}