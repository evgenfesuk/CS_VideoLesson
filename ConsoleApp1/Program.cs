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
            // пеерменная для проверки числа на >0, <0, ==0
            WhatKindOfNumber number = new WhatKindOfNumber();

            // делегаты для разных проверок
            Func<int, bool> IsNegative = number.IsNegative;
            Func<int, bool> IsPositive = number.IsPositive;
            Func<int, bool> IsZero = number.IsZero;



            // переменная для ввода кол-ва секунд для таймера
            int tmpTime = 0;

            // ввод с консоли
            Console.Write("Input seconds: \n");

            // пытаемся конвертировать строку в число
            if(!(int.TryParse(Console.ReadLine(), out tmpTime))) Console.WriteLine("Can not parse to integer");

            // если введенное число >=0 - инициализируем создание и запуск таймера
            if (IsPositive(tmpTime) || IsZero(tmpTime))
            {
                // создаём таймер
                Timer time = new Timer(tmpTime);

                // выбираем способ вывода на экран
                Action<int, int> show = time.ShowNoLine;

                // запускаем таймер с выбраным способом вывода на экран
                time.InitTimer(show);
            }
            else Console.WriteLine("Time can not be negative");

            Console.ReadKey();
        }
    }
}
