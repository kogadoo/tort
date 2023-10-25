using System.IO;
namespace ТоРтИкИ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 3;
            int sum = 0;
            string zakaz = "";
            do
            {
                Console.Clear();
                Menu.Menushka(position, sum, zakaz);
            }
            while (true);
        }
    }
}