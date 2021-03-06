﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль Q_1 Сокращение дробей
    /// Белоголов Григорий
    /// </summary>
    static class Q_1
    {
        /// <summary>
        /// сокращение дроби
        /// </summary>
        /// <param name="A"> Дробь </param>
        /// <returns>Будет возвращенa сокращенная дробь </returns>
        public static Rational Run(Rational A)
        {
            if (A.Clear().Numerator[0] == 0 && A.Numerator.Length == 1)
                return new Rational("0");
            Natural HOD = N_13.Run(Z_5.Run(new Digit(A.Denominator)), Z_5.Run(A.Numerator));// Находим НОД числителя и знаменателя
            A.Numerator = Z_9.Run(A.Numerator, HOD);//Сокращаем числитель на НОД числителя и знаменятеля
            A.Denominator = N_11.Run(A.Denominator, HOD);// Сокращаем знаменатель на нод

            return A;
        }
    }
}