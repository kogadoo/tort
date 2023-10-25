using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТоРтИкИ
{
    internal class Menu
    {
        public static void Menushka(int position, int sum, string zakaz)
        {
            position = 3;
            Console.WriteLine("Заказ тортов в Шараге, выбирай\nВыберите параметр торта\n----------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа\n");
            Console.WriteLine("Цена: " + sum);
            Console.WriteLine("Ваш торт: " + zakaz);
            position = Strelki.Strelkii(position, sum, zakaz, 3, 9);
            Podmenu(position, sum, zakaz);
        }
        private static int Podmenu(int position, int sum, string zakaz)
        {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите че нить");
                Console.WriteLine("Выберите пункт из меню\n-------------------------------------");
                if (position == 3)
                {
                    position = 3;
                    Console.WriteLine("  Круг - 500");
                    Console.WriteLine("  Квадрат - 500");
                    Console.WriteLine("  Прямоугольник - 500");
                    Console.WriteLine("  Сердечко - 700");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 6);
                    switch (position)
                    {
                        case 3:
                            sum += 500;
                            zakaz += "Круг - 500; ";
                            break;
                        case 4:
                            zakaz += "Квадрат - 500; ";
                            sum += 500;
                            break;
                        case 5:
                            zakaz += "Прямоугольник - 500; ";
                            sum += 500;
                            break;
                        case 6:
                            zakaz += "Сердечко - 700; ";
                            sum += 700;
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 4)
                {
                    position = 3;
                    Console.WriteLine("  Маленький - 1000");
                    Console.WriteLine("  Обычный - 1500");
                    Console.WriteLine("  Большой - 2000");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 5);
                    switch (position)
                    {
                        case 3:
                            zakaz += "Маленький - 1000; ";
                            sum += 1000;
                            break;
                        case 4:
                            zakaz += "Обычный - 1500; ";
                            sum += 1500;
                            break;
                        case 5:
                            zakaz += "Большой - 2000; ";
                            sum += 2000;
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 5)
                {
                    position = 3;
                    Console.WriteLine("  Ванильный - 200");
                    Console.WriteLine("  Шоколадный - 100");
                    Console.WriteLine("  Карамельный - 100");
                    Console.WriteLine("  Ягодный - 300");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 6);
                    switch (position)
                    {
                        case 3:
                            sum += 200;
                            zakaz += "Ванильный - 200; ";
                            break;
                        case 4:
                            zakaz += "Шоколадный - 100; ";
                            sum += 100;
                            break;
                        case 5:
                            zakaz += "Карамельный - 100; ";
                            sum += 100;
                            break;
                        case 6:
                            zakaz += "Ягодный - 300; ";
                            sum += 300;
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 6)
                {
                    position = 3;
                    Console.WriteLine("  1 корж - 200");
                    Console.WriteLine("  2 коржа - 400");
                    Console.WriteLine("  3 коржа - 600");
                    Console.WriteLine("  4 коржа - 800");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 6);
                    switch (position)
                    {
                        case 3:
                            zakaz += "1 корж - 200; ";
                            sum += 200;
                            break;
                        case 4:
                            zakaz += "2 коржа - 400; ";
                            sum += 400;
                            break;
                        case 5:
                            zakaz += "3 коржа - 600; ";
                            sum += 600;
                            break;
                        case 6:
                            zakaz += "4 коржа - 800; ";
                            sum += 800;
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 7)
                {
                    position = 3;
                    Console.WriteLine("  Шоколад - 110");
                    Console.WriteLine("  Крем - 150");
                    Console.WriteLine("  Бизе - 200");
                    Console.WriteLine("  Ягоды - 100");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 6);
                    switch (position)
                    {
                        case 3:
                            zakaz += "Шоколад - 110; ";
                            sum += 110;
                            break;
                        case 4:
                            zakaz += "Крем - 150; ";
                            sum += 150;
                            break;
                        case 5:
                            zakaz += "Бизе - 200; ";
                            sum += 200;
                            break;
                        case 6:
                            zakaz += "Ягоды - 100; ";
                            sum += 100;
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 8)
                {
                    position = 3;
                    Console.WriteLine("  Шоколадная - 150");
                    Console.WriteLine("  Ягодная - 200");
                    Console.WriteLine("  Кремовая - 100");
                    position = Strelki.Strelkii(position, sum, zakaz, 3, 5);
                    switch (position)
                    {
                        case 3:
                            sum += 150;
                            zakaz += "Шоколадная - 150; ";
                            break;
                        case 4:
                            sum += 200;
                            zakaz += "Ягодная - 200; ";
                            break;
                        case 5:
                            sum += 100;
                            zakaz += "Кремовая - 100; ";
                            break;
                    }
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
                else if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Записал братишка, если хочешь еще, нажми Escape по братски");
                    File.AppendAllText("C:\\Users\\Пользователь\\Desktop\\История заказов.txt", "Заказ от: " + DateTime.Now.ToString() + "\n");
                    File.AppendAllText("C:\\Users\\Пользователь\\Desktop\\История заказов.txt", "Ваш заказ:  " + zakaz + "\n");
                    File.AppendAllText("C:\\Users\\Пользователь\\Desktop\\История заказов.txt", "Сумма заказа:  " + sum.ToString());
                    sum = 0;
                    zakaz = "";
                }
                Strelki.Strelkii(position, sum, zakaz, 0, 0);
            return sum;
        }
    }
}
