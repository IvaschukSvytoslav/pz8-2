using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    class Program
    {
        delegate void ColorInfo();

        static void Main()
        {
            Console.Write("Введіть номер кольору у спектрі (1-7): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int colorNumber) && colorNumber >= 1 && colorNumber <= 7)
            {
                ColorInfo[] methods = { Red, Orange, Yellow, Green, Blue, Indigo, Violet };
                methods[colorNumber - 1]();
            }
            else
            {
                Console.WriteLine("Некоректний номер кольору.");
            }
        }

        static void Red() => Console.WriteLine("Червоний - RGB: (255, 0, 0)");
        static void Orange() => Console.WriteLine("Помаранчевий - RGB: (255, 165, 0)");
        static void Yellow() => Console.WriteLine("Жовтий - RGB: (255, 255, 0)");
        static void Green() => Console.WriteLine("Зелений - RGB: (0, 255, 0)");
        static void Blue() => Console.WriteLine("Блакитний - RGB: (0, 255, 255)");
        static void Indigo() => Console.WriteLine("Синій - RGB: (0, 0, 255)");
        static void Violet() => Console.WriteLine("Фіолетовий - RGB: (128, 0, 128)");
    }

}
