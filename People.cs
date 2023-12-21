using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class People
    {
        protected string name;
        protected int age;
        protected virtual void InfoIn()
        {
            string input;
            Console.Write("Имя: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Возраст (от 16 до 50): ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out age) == false)
                {
                    Console.WriteLine("ОШИБКА!!! Возраст должен состоять только из цифр\nНажмите Enter и попробуйте ещё раз . . .");
                    do
                    {
                        //Nothing
                    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.Clear();
                    Console.WriteLine($"Имя: {name}");
                }
                else
                {
                    if (age < 16 || age > 50)
                    {
                        Console.WriteLine("ОШИБКА!!! Возраст должен быть от 16 до 50 лет\nНажмите Enter и попробуйте ещё раз . . .");
                        do
                        {
                            //Nothing
                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                        Console.Clear();
                        Console.WriteLine($"Имя: {name}");
                    }
                }
            } while (Int32.TryParse(input, out age) == false || age < 16 || age > 50);
        }
    }
}
