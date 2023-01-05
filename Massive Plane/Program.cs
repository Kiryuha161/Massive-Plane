using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_Plane
{
    internal class Program
    {
        //ctrl + r + r - изменить название всех переменных с одним названием в одной зоне видимости
        //ctrl + k + d - выравнивание
        //выделение + ctrl + k + s - закомментирование выделенного
        //выделение + ctrl + k + u - раскомментирование выделенного
        static void Main(string[] args)
        {
            int[] seats = { 10, 30, 15, 15, 20 }; //первый класс (носовая часть),
                                                  //бизнес-класс (основная часть самолёта),
                                                  //эконом класс - 1 (левое крыло сзади),
                                                  //эконом класс - 2 (правое крыло сзади),
                                                  //эконом класс - 3 (хвост)
            int money = 0;
            int price;

            while (true)
            {
                Console.WriteLine("Билеты в какую часть самолёта вы хотите купить? Введите:");
                Console.WriteLine("1К (1C) - для первого класса, \nБК (BC) - для бизнес класса, \n" +
                    "ЭК1 (EC1) (левое крыло сзади), \nЭК2 (EC2) (правое крыло сзади), " +
                    "\nЭК3 (EC3) (хвост) для эконом класса, выход (exit), чтобы выйти из программы");

                Console.WriteLine($"Всего мест: для первого класса - " +
                    $"{seats[0]}, для бизнес класса -  {seats[1]}, " +
                    $"для эконом-класса в левом крыле сзади - {seats[2]}, " +
                    $"для эконом-класса в правом крыле сзади - {seats[3]}, " +
                    $"для эконом-класса в хвосте - {seats[4]}");

                string placeInPlane = Console.ReadLine();
                if (placeInPlane == "Exit" || placeInPlane == "Выход")
                {
                    break;
                }

                switch (placeInPlane)
                {
                    case "1К":
                    case "1C":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        int countTicket = Convert.ToInt32(Console.ReadLine());
                        if (countTicket > seats[0])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }

                        else
                        {
                            price = 10000;
                            int totalPrice = price * countTicket;
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на первый класс. " +
                                $"Cумма покупки {totalPrice}");
                            money += totalPrice;
                            Console.WriteLine($"Бюджет кассы - {money}");
                            seats[0] -= countTicket;
                        }
                        break;
                    case "БК":
                    case "BC":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (countTicket > seats[1])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }

                        else
                        {
                            price = 7500;
                            int totalPrice = price * countTicket;
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на бизнес-класс. " +
                                $"Cумма покупки {totalPrice}");
                            money += totalPrice;
                            Console.WriteLine($"Бюджет кассы - {money}");
                            seats[1] -= countTicket;
                        }
                        break;
                    case "ЭК1":
                    case "EC1":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (countTicket > seats[2])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }

                        else
                        {
                            price = 5000;
                            int totalPrice = price * countTicket;
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом класс в левой " +
                                $"части сзади. " + $"Cумма покупки {totalPrice}");
                            money += totalPrice;
                            Console.WriteLine($"Бюджет кассы - {money}");
                            seats[2] -= countTicket;
                        }
                        break;
                    case "ЭК2":
                    case "EC2":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (countTicket > seats[3])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }

                        else
                        {
                            price = 5000;
                            int totalPrice = price * countTicket;
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом класс в левой " +
                                $"части сзади. " + $"Cумма покупки {totalPrice}");
                            money += totalPrice;
                            Console.WriteLine($"Бюджет кассы - {money}");
                            seats[3] -= countTicket;
                        }
                        break;
                    case "ЭК3":
                    case "EC3":
                        Console.WriteLine("Введите сколько билетов вы хотите приобрести?");
                        countTicket = Convert.ToInt32(Console.ReadLine());

                        if (countTicket > seats[4])
                        {
                            Console.WriteLine("К сожалению, билетов нет");
                        }

                        else
                        {
                            price = 5000;
                            int totalPrice = price * countTicket;
                            Console.WriteLine($"У вас {countTicket} билет(ов/а) на эконом класс в хвосте" +
                                $"Cумма покупки {totalPrice}");
                            money += totalPrice;
                            Console.WriteLine($"Бюджет кассы - {money}");
                            seats[4] -= countTicket;
                        }
                        break;
                    default:
                        Console.WriteLine("Мы не знаем такой команды");
                        break;
                        
                }
                
            }
        }
    }
}










