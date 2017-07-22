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
            BooleanDelegate IsNegative = number.IsNegative;
            BooleanDelegate IsPositive = number.IsPositive;
            BooleanDelegate IsZero = number.IsZero;

            // таймер
            Timer time = new Timer();

            // делегат для запуска таймера
            TimerDelegate InitTimer = time.InitTimer;

            // переменная для ввода кол-ва секунд для таймера
            int tmpTime;

            // ввод с консоли
            Console.Write("Input seconds: ");

            // пытаемся конвертировать строку в число
            if(!(int.TryParse(Console.ReadLine(), out tmpTime))) Console.WriteLine("Can not parse to integer"); ;

            // если введенное число >=0 - запускаем таймер
            // вариант 1
            /*if (UseDelegate(IsPositive, tmpTime) || UseDelegate(IsZero, tmpTime)) UseDelegate(InitTimer, tmpTime); 
            else Console.WriteLine("Time can not be negative");*/

            // вариант 2
            if (IsPositive(tmpTime) || IsZero(tmpTime)) InitTimer(tmpTime);
            else Console.WriteLine("Time can not be negative");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для работы с делегатами по проверке числа на >0, <0, ==0
        /// </summary>
        /// <param name="method">Передаваемый метод</param>
        /// <param name="num">Проверяемое число</param>
        /// <returns></returns>
        static bool UseDelegate(BooleanDelegate method, int num)
        {
            return method(num);
        }


        /// <summary>
        /// Метод для работы с делегатами для работы с таймером
        /// </summary>
        /// <param name="method">Передаваемый метод</param>
        /// <param name="time">Время в секундах</param>
        static void UseDelegate(TimerDelegate method, int time)
        {
            method(time);
        }
    }
}
