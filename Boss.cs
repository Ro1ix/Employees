using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Boss : Employee
    {
        private void SalaryOverWork(int overDay, int overNight)
        {
            salary = 50000 + 50000 * 0.02 * overDay + 50000 * 0.03 * overNight;    /*50000 - оклад начальника, 0.02 - надбавка за дневные переработки, 0.03 - надбавка за ночные переработки*/
        }
        protected void InfoOut()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Отдел: {section}");
            Console.WriteLine($"Дневные смены: {workDay}/{planDay}");
            if (age >= 18)
            {
                Console.WriteLine($"Ночные смены: {workNight}/{planNight}");
            }
            Console.WriteLine($"Общая зарплата: {salary}");
        }
        public void InfoOutPublic()
        {
            Work();
            OverWork();
            InfoOut();
        }
    }
}
