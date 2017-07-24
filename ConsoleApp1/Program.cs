using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Action возвращает void, Predicate возвращает bool, а Func возвращает указанный результат 
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // пеерменная для проверки числа на >0, <0, ==0
            WhatKindOfNumber number = new WhatKindOfNumber();

            // делегаты для разных проверок
            // Predicate<T> — метод, который принимает аргумент типа T и возвращает bool
            Predicate<int> IsNegative = number.IsNegative;
            Predicate<int> IsPositive = number.IsPositive;
            Predicate<int> IsZero = number.IsZero;



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
