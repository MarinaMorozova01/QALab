﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Марина";
            int min = int.MinValue;
            uint max = int.MaxValue;
            bool choose = false;
            byte page = 111;
            sbyte depth = -88;
            double weight = 52.2;
            char star = '*';
            long population = 7926251830;
            ulong cheque = 13214654654;
            float temperature = 45;
            decimal money = 8372.7654m;
            short distance = 1250;

            ///////////

            int firstValue = 20;
            int secondValue = 5;
            Console.WriteLine($"Решить выражение используя следующие данные: \n \t Первое значение- {firstValue} \n\t Второе значение-  {secondValue} ");

            if ((--firstValue + secondValue) != ((firstValue * secondValue++) % 3))
            {
                Console.WriteLine("Значения не равны");
            }
            else if ((firstValue-- + secondValue++ - 20) == (firstValue / secondValue))
            {
                Console.WriteLine("Значения равны");
            }

            Console.WriteLine(firstValue-- == 4 ? "Да" : "Нет");

            bool resultIs = firstValue is int;
            Console.WriteLine(resultIs);

            string text = null;
            string checkNull = text as string;

            bool operatorOr = firstValue > secondValue | secondValue == firstValue * 4;
            bool operatorAnd = firstValue == secondValue & firstValue >= secondValue / 4;
























        }
    }
}
