﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4._1
{
    /// <summary>
    /// Division class
    /// </summary>
    public class Division : Operation
    {
        /// <summary>
        /// Output expression with division
        /// </summary>
        public override void Print()
        {
            Console.Write("(");
            LeftChild.Print();
            Console.Write("/");
            RightChild.Print();
            Console.Write(")");
        }

        /// <summary>
        /// Division counting
        /// </summary>
        /// <returns>Result of division</returns>
        public override double Counting()
        {
            double result = 0;
            try
            {
                double value1 = LeftChild.Counting();
                double value2 = RightChild.Counting();
                result = LeftChild.Counting() / RightChild.Counting();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Некорректный ввод : деление на ноль");
                Environment.Exit(1);
            }
            return result;
        }       
    }
}
