namespace ТоРтИкИ
{
    internal class Strelki
    {
        public static int Strelkii(int position, int sum, string zakaz, int min, int max)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == min - 1)
                        position = max;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == max + 1)
                        position = min;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu.Menushka(position, sum, zakaz);
                }
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
    }
}


