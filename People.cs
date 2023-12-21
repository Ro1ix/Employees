using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class People
    {
        private string name;
        private int age;
        public void Start()
        {
            InfoIn();
        }
        private void InfoIn()
        {
            string input;
            Console.Write("Имя: ");
            name = Console.ReadLine();
            Console.Write("Возраст: ");
            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out age) == false)
                {
                    Console.WriteLine("ОШИБКА!!! Возраст должен состоять только из цифр\nНажмите Enter и попробуйте ещё раз");
                    do
                    {
                        //Nothing
                    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

                }
            } while (Int32.TryParse(input, out age) == false);
            if 
        }
    }
}
