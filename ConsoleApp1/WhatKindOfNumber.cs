using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
    /// <summary>
    /// Делегат для работы с проверкой числа на >0, <0, ==0
    /// </summary>
    /// <param name="num">Проверяемое число</param>
    /// <returns></returns>
    public delegate bool BooleanDelegate(int num);*/


    /// <summary>
    /// Класс для проверки числа на >0, <0, ==0
    /// </summary>
    public class WhatKindOfNumber
    {
        /// <summary>
        /// Больше 0?
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns></returns>
        public bool IsPositive(int num)
        {
            if (num > 0) return true;
            else return false;
        }

        /// <summary>
        /// Меньше 0?
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns></returns>
        public bool IsNegative(int num)
        {
            if (num < 0) return true;
            else return false;
        }

        /// <summary>
        /// 0?
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <returns></returns>
        public bool IsZero(int num)
        {
            if (num == 0) return true;
            else return false;
        }
    }
}
