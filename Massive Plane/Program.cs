using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_Plane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seats = { 10, 30, 15, 15, 20 }; //первый класс (носовая часть),
                                                  //бизнес-класс (основная часть самолёта),
                                                  //эконом класс - 1 (левое крыло сзади),
                                                  //эконом класс - 2 (правое крыло сзади),
                                                  //эконом класс - 3 (хвост)

            while (true)
            {
                Console.WriteLine("Билеты в какую часть самолёта вы хотите купить? Введите:");
                Console.WriteLine("1К (1C) - для первого класса, \nБК (BC) - для бизнес класса, \n" +
                    "ЭК1 (EC1) (левое крыло сзади), \nЭК2 (EC2) (правое крыло сзади), " +
                    "\nЭК3 (EC3) (хвост) для эконом класса");

                Console.WriteLine($"Всего мест: для первого класса - " +
                    $"{seats[0]}, для бизнес класса -  {seats[1]}, " +
                    $"для эконом-класса в левом крыле сзади - {seats[2]}, " +
                    $"для эконом-класса в правом крыле сзади - {seats[3]}, " +
                    $"для эконом-класса в хвосте - {seats[4]}");

                string placeInPlane = Console.ReadLine();

                switch (placeInPlane)
                {
                    case "1К":
                    case "1С":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        int countTicket = Convert.ToInt32(Console.ReadLine());
                        if (countTicket > seats[0])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }
                        else Console.WriteLine($"У вас {countTicket} билет(ов/а) на первый класс.");
                        seats[0] -= countTicket;
                        break;
                    case "БК":
                    case "BC":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (seats[1] > 0)
                        {
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на бизнес-класс.");
                        }
                        else if (seats[1] < 0)
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }
                        seats[1] -= countTicket;
                        break;
                    case "ЭК1":
                    case "EC1":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (seats[2] > 0)
                        {
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом-класс в " +
                             $"левой части сзади.");
                        }
                        else if (seats[2] < 0)
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }
                        seats[2] -= countTicket;
                        break;
                    case "ЭК2":
                    case "EC2":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (seats[3] > 0)
                        {
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом-класс в " +
                            $"правой части сзади.");
                        }
                        else if (seats[3] < 0)
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }
                        seats[2] -= countTicket;
                        break;
                    case "ЭК3":
                    case "EC3":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (seats[4] > 0)
                        {
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом-класс в " +
                            $"хвосте.");
                        }
                        else if (seats[4] < 0)
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }
                        seats[2] -= countTicket;
                        break;
                    default:
                        Console.WriteLine("Мы не знаем такой команды");
                        break;
                }

            }
        }
    }
}










