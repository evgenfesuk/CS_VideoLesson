using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    /// <summary>
    /// Какой-то способ вывода на экран результата работы таймера
    /// </summary>
    /// <param name="i">Текущее состояние таймера</param>
    /// <param name="timer">Финальное значение таймера</param>
    public delegate void ShowDelegate(int i, int timer);

    /// <summary>
    /// Класс Timer
    /// </summary>
    public class Timer
    {
        private int _time;

        public int Time
        {
            get => _time;
            set
            {
                if (value >= 0) _time = value;
                else throw new Exception("Only positive time!");
            }
        }

        /// <summary>
        /// Вывод на экран построчно
        /// </summary>
        /// <param name="i">Текущее состояние таймера</param>
        /// <param name="timer">Финальное значение таймера</param>
        public void ShowLine(int i, int timer)
        {
            Console.Clear(); // очистка строки
            Console.WriteLine("Timer for {0} seconds started", timer); // вывод сообщения о величине таймера
            if (i-1 > 0) // если 1 секунда уже выведена на экран
            {
                for (int j=1; j<i-1; j++) // если это вторая секунда - идём мимо
                Console.WriteLine(j); // если это 3 и больше секунда - заново выводим первую секунду на экран

                Console.WriteLine(i - 1); // выводим значение текущего таймера-1
            }
            Console.WriteLine(i); // выводим значение текущего таймера
            if (i == timer) Console.Beep(); // звуковое оповещение по окончании
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Вывод на экран в одну строку
        /// </summary>
        /// <param name="i">Текущее состояние таймера</param>
        /// <param name="timer">Финальное значение таймера</param>
        public void ShowNoLine(int i, int timer)
        {
            Console.Clear(); // очистка строки
            Console.WriteLine("Timer for {0} seconds started", timer); // вывод сообщения о величине таймера
            Console.Write(i); // вывод таймера
            if (i == timer) Console.Beep(); // звуковое оповещение по окончании
            Thread.Sleep(1000); // ждём 1 сек
        }

        /// <summary>
        /// Запуск таймера с заданым временем и делегатом вывода на экран
        /// </summary>
        /// <param name="time">Время в секундах</param>
        /// <param name="show">Один из вариантов вывода на экран</param>
        public void InitTimer(int time, ShowDelegate show)
        {
            for (int i = 1; i <= time; i++)
            {
                show(i, time);
            }
        }

        /// <summary>
        /// Запуск таймера без явного указания времени, но с делегатом вывода на экран
        /// </summary>
        /// <param name="show">Один из вариантов вывода на экран</param>
        public void InitTimer(ShowDelegate show)
        {
            InitTimer(Time, show);
        }

        /// <summary>
        /// Конструктор без параметров, Time =0
        /// </summary>
        public Timer()
        {
            Time = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="time">Время в секундах</param>
        public Timer(int time)
        {
            Time = time;
        }
    }
}
