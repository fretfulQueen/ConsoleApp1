using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Анкета

            Console.Title = "Анкета";

            Console.WriteLine("Введите ваше имя:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост:");
            string height = Console.ReadLine();

            Console.WriteLine("Введите ваш вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("Вас зовут " + name1 + " " + surname + ", вам " + age + ", вы " + height + " см в высоту, а ваш вес " + weight + " килограмм.");
            Console.WriteLine("Вас зовут {0} {1}, вам {2}, вы {3} см в высоту, а ваш вес {4} килограмм", name1, surname, age, height, weight);
            Console.WriteLine($"Вас зовут {name1} {surname}, вам {age}, вы {height} см в высоту, а ваш вес {weight} килограмм");

            Console.ReadLine();

            #endregion

            #region ИМТ

            Console.Title = "ИМТ";
            Console.Clear();

            Console.WriteLine("Введите ваш вес:");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост:");
            double h = double.Parse(Console.ReadLine());

            double I = m * 10000 / (h * h);

            Console.WriteLine("Ваш индекс массы тела {0:F2} ", I);


            Console.ReadLine();

            #endregion

            #region Координаты

            Console.Title = "Координаты";
            Console.Clear();

            Console.WriteLine("Введите x1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2:");
            double y2 = double.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.ReadLine();


            #endregion

            #region Обмен значениями

            Console.Title = "Обмен Значениями";
            Console.Clear();

            Console.WriteLine("Введите значение для обмена:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение для обмена:");
            int b = Int32.Parse(Console.ReadLine());

            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"Обмен успешно совершен, первое значени равно {a}, а второе {b}");
            Console.ReadLine();



            #endregion

            #region Центр

            Console.Title = "Центр";
            Console.Clear();

            string centerText = "Меня зовут Денис Голованов, я живу в Спб";

            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centerText);

            Console.ReadLine();

            #endregion

        }

    }
}
