﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вычитание целых чисел
    /// Кирилл Першин + Бараняк Данила
    /// </summary>
    static class Z_7
    {
        /// <summary>
        /// Вычитание целых чисел (в т.ч. отрицательных)
        /// </summary>
        /// <param name="A">Уменьшаемое</param>
        /// <param name="B">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static Digit Run(Digit A, Digit B)
        {
            Digit result = new Digit("0");
            result.Sign = true;

            int len = Math.Min(A.Length, B.Length);
            switch (N_1.Run(A.Value, B.Value))
            {
                case 1:
                    if (A.Sign == B.Sign)
                        result = Dif(A, B, len);
                    else
                        result.Value = N_4.Run(A.Value, B.Value);
                    result.Sign = A.Sign;
                    break;

                case 2:
                    if (A.Sign == B.Sign)
                        result = Dif(B, A, len);
                    else
                        result.Value = N_4.Run(A.Value, B.Value);
                    result.Sign = !B.Sign;
                    break;

                case 0:
                    if (A.Sign != B.Sign)
                        result = new Digit(N_6.Run(A.Value, 2));
                    result.Sign = A.Sign;
                    break;
            }
            return result.Clear();
        }


        /// <summary>
        /// Функция вычитания
        /// </summary>
        static Digit Dif(Digit D1, Digit D2, int len)
        {
            int[] a = new int[D1.Value.Length];
            for (int i = 0; i < D1.Value.Length; i++)
            {
                a[i] = D1.Value[i];
            }
            Digit Result = new Digit(true, a);
            for (int i = len - 1; i >= 0; i--)
            {

                Result[i] -= D2[i];                         // Поразрядное вычитание

                if (Result[i] < 0)                          // Если меньше нуля, занять десятку у более высокого разряда
                {
                    Result[i] += 10;
                    Result[i + 1]--;
                }
            }
            return Result;
        }
    }
}