using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + "  " + number2 + "  " + number3);
            Console.ReadKey();

            //задание 2
            Console.WriteLine("5 \n10 \n21");
            Console.ReadKey();

            //задание 3
            Console.WriteLine("Введите расстояние в сантиметрах: ");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("В этом расстоянии {0} полных метра", distance / 100);
            Console.ReadKey();

            //задание 4
            int weeks = 234 / 7;
            Console.WriteLine("С некоторого момента прошло {0} недель", weeks);
            Console.ReadKey();

            //задание 5
            Console.WriteLine("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("В данном числе {0} десятков ", number / 10);
            Console.WriteLine("В данном числе {0} едениц ", number % 10);
            int sum = 0;
            int composition = 1;
            while (number != 0)
            {
                sum += number % 10;
                composition *= number % 10;
                number /= 10;
            }
            Console.WriteLine("Сумма цифр в числе {0} ", sum);
            Console.WriteLine("Произведение цифр в числе {0} ", composition);
            Console.ReadKey();

            //задание 6
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            Console.ReadKey();

            //задание 7
            Console.WriteLine("Введите сторону квадрата: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата: ");
            double radius = double.Parse(Console.ReadLine());
            if (side * side > Math.PI * radius * radius)
            {
                Console.WriteLine("Площадь квадрата больше чем у круга");
            }
            else
            {
                Console.WriteLine("Площадь круга больше чем у квадрата");
            }
            Console.ReadKey();

            //задание 8
            Console.WriteLine("Введите обьем и массу первого тела");
            double volume1 = double.Parse(Console.ReadLine());
            double weight1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите обьем и массу второго тела");
            double volume2 = double.Parse(Console.ReadLine());
            double weight2 = double.Parse(Console.ReadLine());
            if (weight1 / volume1 > weight2 / volume2)
            {
                Console.WriteLine("Плотность первого тела больше чем у второго");
            }
            else if (weight1 / volume1 < weight2 / volume2)
            {
                Console.WriteLine("Плотность второго тела больше чем у первого");
            }
            else
            {
                Console.WriteLine("Плотность у двух тел одинаковая");
            }
            Console.ReadKey();

            //задание 9
            Console.WriteLine("Введите сопротивление и напряжение первой электро цепи: ");
            double resist1 = double.Parse(Console.ReadLine());
            double voltage1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление и напряжение второй электро цепи: ");
            double resist2 = double.Parse(Console.ReadLine());
            double voltage2 = double.Parse(Console.ReadLine());
            if (voltage1 / resist1 > voltage2 / resist2)
            {
                Console.WriteLine("Сила тока в первой цепи больше чем во второй");
            }
            else if (voltage1 / resist1 < voltage2 / resist2)
            {
                Console.WriteLine("Сила тока во второй цепи больше чем в первой");
            }
            else
            {
                Console.WriteLine("Сила тока в двух цепях одинакова");
            }
            Console.ReadKey();

            //задание 10
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Введите число до которого будут считаться квадраты чисел, число должно быть больше 10");
            int maxValue = int.Parse(Console.ReadLine());
            if (maxValue > 10)
            {
                for (int i = 10; i < maxValue; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            else if (maxValue < 10)
            {
                Console.WriteLine("Ошибка, число < 10");
            }
            Console.WriteLine("Введите число от которого будут считаться третьи степени чисел, число должно быть меньше 50");
            int minValue = int.Parse(Console.ReadLine());
            if (minValue < 50)
            {
                for (int i = minValue; i < 50; i++)
                {
                    Console.WriteLine(i * i * i);
                }
            }
            else if (minValue > 50)
            {
                Console.WriteLine("Ошибка, число > 50");
            }
            Console.WriteLine("Введите 2 числа (число 1 должно быть > чем число 2)");
            minValue = int.Parse(Console.ReadLine());
            maxValue = int.Parse(Console.ReadLine());
            if (minValue < maxValue)
            {
                for (int i = minValue; i < maxValue; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (minValue > maxValue)
            {
                Console.WriteLine("Ошибка, число 1 > чем число 2");
            }
            Console.ReadKey();
        }
    }
}
