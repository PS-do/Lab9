using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, rez;
            int k;
            Console.WriteLine("\"Калькулятор\" запущен");
            try
            {
                Console.WriteLine("Введите первое число:");
                x1 = Convert.ToDouble(Console.ReadLine());
                try
                {
                    Console.WriteLine("Введите второе число:");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите код операции:\n" +
                        "\t1\t-\tСложение\n" +
                        "\t2\t-\tВычитание\n" +
                        "\t3\t-\tпроизведение\n" +
                        "\t4\t-\tчастное\n");
                    Console.Write("Ваш выбор:");
                    try
                    {
                        k = Convert.ToInt32(Console.ReadLine());
                        switch (k)
                        {
                            //case 0:
                            //    {
                            //        Console.WriteLine();
                            //        break;
                            //    }
                            case 1:
                                {
                                    Console.WriteLine(x1 + x2);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(x1 - x2);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(x1 * x2);
                                    break;
                                }
                            case 4:
                                {
                                    try 
                                    { Console.WriteLine(x1 / x2); }// !!Подскажите пожалуйста, почему здесь не выскакивает сообщение об ошибке?
                                    catch 
                                    {
                                        Console.WriteLine("Деление на 0!");
                                    }
                                    break;
                                }
                            default:
                                { 
                                    Console.WriteLine("Введена не верная команда");
                                    break;
                                }
                        }
                    }
                    catch
                    {

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
