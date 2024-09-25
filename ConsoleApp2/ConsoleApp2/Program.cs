using System;
using System.Collections.Generic;

namespace Дурка
{
    class Program
    {
        static void Main(string[] args)
        {
            var ruca = new List<string> { "Мышь (дышит)", "Колесо от инвалидной коляски", "Манга по ДжоДжо" };
            var sumka = new List<string>();

            while (true)
            {
                Console.WriteLine("Выберите команду:");
                Console.WriteLine("1. Посмотреть, что находится в руках");
                Console.WriteLine("2. Посмотреть, что находится в сумке");
                Console.WriteLine("3. Переложить");
                Console.WriteLine("4. Уйти из этого дурдома");

                var comand = Console.ReadLine();

                switch (comand)
                {
                    case "1":                     
                        Console.WriteLine("В руках:");
                        if (ruca.Count == 0)
                        {
                            Console.WriteLine("Ничего");
                        }
                        else
                        {
                            foreach (var item in ruca)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("В сумке:");
                        if (sumka.Count == 0)
                        {
                            Console.WriteLine("Ничего");
                        }
                        else
                        {
                            foreach (var предмет in sumka)
                            {
                                Console.WriteLine(предмет);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Выберите, откуда что-то переложить:");
                        Console.WriteLine("1. Из рук");
                        Console.WriteLine("2. Из сумки");

                        var saveitem = Console.ReadLine();

                        if (saveitem == "1")
                        {
                            if (ruca.Count == 0)
                            {
                                Console.WriteLine("Руки пусты");
                            }
                            else
                            {
                                Console.WriteLine("Выберите предмет:");
                                for (int i = 0; i < ruca.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {ruca[i]}");
                                }

                                var itemIndex = int.Parse(Console.ReadLine()) - 1;
                                var item = ruca[itemIndex];
                                ruca.RemoveAt(itemIndex);
                                sumka.Add(item);
                                Console.WriteLine($"Предмет '{item}' перемещен в сумку");
                            }
                        }
                        else if (saveitem == "2")
                        {
                            if (sumka.Count == 0)
                            {
                                Console.WriteLine("Сумка пуста");
                            }
                            else
                            {
                                Console.WriteLine("Выберите предмет:");
                                for (int i = 0; i < sumka.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {sumka[i]}");
                                }

                                var itemIndex = int.Parse(Console.ReadLine()) - 1;
                                var item = sumka[itemIndex];
                                sumka.RemoveAt(itemIndex);
                                ruca.Add(item);
                                Console.WriteLine($"Предмет '{item}' перемещен в руку");
                            }
                        }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неправильная команда");
                        break;
                }
            }
        }
    }
}