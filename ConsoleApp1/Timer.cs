using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{

    /// <summary>
    /// Делегат для таймера
    /// </summary>
    /// <param name="time"></param>
    public delegate void TimerDelegate(int time);


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
        /// Запуск таймера с заданым временем
        /// </summary>
        /// <param name="time">Время в секундах</param>
        public void InitTimer(int time)
        {
            for (int i = 1; i <= time; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Запуск таймера без явного указания вреемни
        /// </summary>
        public void InitTimer()
        {
            InitTimer(Time);
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
