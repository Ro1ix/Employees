using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сотудники";
            Employee[] employees = new Employee[4];
            Boss[] bosses = new Boss[2];
            int countEmployees = 0;
            int countBosses = 0;
            Menu(employees, bosses, countEmployees, countBosses);
        }
        static void Menu(Employee[] employees, Boss[] bosses, int countEmployees, int countBosses)
        {
            Console.WriteLine("МЕНЮ\n");
            Console.WriteLine("1. Добавить нового сотрудника");
            Console.WriteLine("2. Добавить нового начальника");
            Console.WriteLine("3. Посмотреть информацию");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    if (countEmployees < 10)
                    {
                        employees[countEmployees] = new Employee();
                        employees[countEmployees].Start();
                        countEmployees++;
                        Console.WriteLine("\nСотрудник добавлен. Нажмите Enter, чтобы вернуться в меню . . .");
                        do
                        {
                            //Nothing
                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                        Console.Clear();
                        Menu(employees, bosses, countEmployees, countBosses);
                    }
                    else
                    {
                        Console.WriteLine("Все сотрудники добавлены. Нажмите Enter, чтобы вернуться в меню . . .");
                        do
                        {
                            //Nothing
                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                        Console.Clear();
                        Menu(employees, bosses, countEmployees, countBosses);
                    }
                    break;
                case "2":
                    Console.Clear();
                    if (countBosses < 10)
                    {
                        bosses[countBosses] = new Boss();
                        bosses[countBosses].Start();
                        countBosses++;
                        Console.WriteLine("\nНачальник добавлен. Нажмите Enter, чтобы вернуться в меню . . .");
                        do
                        {
                            //Nothing
                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                        Console.Clear();
                        Menu(employees, bosses, countEmployees, countBosses);
                    }
                    else
                    {
                        Console.WriteLine("Все начальники добавлены. Нажмите Enter, чтобы вернуться в меню . . .");
                        do
                        {
                            //Nothing
                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                        Console.Clear();
                        Menu(employees, bosses, countEmployees, countBosses);
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("СОТРУДНИКИ\n---------------");
                    for (int i = 0; i < countEmployees; i++)
                    {
                        employees[i].InfoOutPublic();
                        
                        Console.WriteLine();
                    }
                    Console.WriteLine("НАЧАЛЬНИКИ\n---------------");
                    for (int i = 0; i < countBosses; i++)
                    {
                        bosses[i].InfoOutPublic();
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Нажмите Enter и попробуйте ещё раз . . .");
                    do
                    {
                        //Nothing
                    } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    Console.Clear();
                    Menu(employees, bosses, countEmployees, countBosses);
                    break;
            }
        }
    }
}
