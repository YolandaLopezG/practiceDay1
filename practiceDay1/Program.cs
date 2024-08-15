using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------
            /*Given an array of integers, calculate the ratios of its elements that are positive,
             * negative, and zero. Print the decimal value of each fraction on a new line with 
             * places after the decimal.*/

            List<int> plusList = new List<int>() { -4, 3, -9, 0, 4, 1 };

            plusMinus(plusList);

            //----------------------------------------------------------

            //----------------------------------------------------------
            /*Given five positive integers, find the minimum and maximum values that can be 
             * calculated by summing exactly four of the five integers. Then print the respective
             * minimum and maximum values as a single line of two space-separated long integers.*/

            List<int> maxList = new List<int>() { 1, 2, 3, 4, 5 };

            miniMaxSum(maxList);

            //----------------------------------------------------------

            //----------------------------------------------------------
            /*Given a time in -hour AM/PM format, convert it to military (24-hour) time.
             * Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
             * - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.*/

            string time = "07:05:45PM";

            Console.WriteLine(timeConvertion(time));

            //----------------------------------------------------------

        }

        static void plusMinus(List<int> arr)
        {
            int len = arr.Count;

            float pos = 0, neg = 0, neu = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
                else
                {
                    neu++;
                }
            }
            Console.WriteLine("{0:F6} ", pos / len);
            Console.WriteLine("{0:F6} ", neg / len);
            Console.WriteLine("{0:F6} ", neu / len);
        }

        static void miniMaxSum(List<int> arr)
        {
            long suma = arr.Sum(x => (long)x);

            long max = arr.Max();
            long min = arr.Min();

            long maxSum = suma - min;
            long minSum = suma - max;

            Console.WriteLine($"{minSum} {maxSum}");
        }

        static string timeConvertion(string s)
        {
            string inicio = "";
            string final = "";
            int largo = s.Length;

            inicio = s.Substring(0, 2);
            final = s.Substring(s.Length - 2, 2);

            var numero = Convert.ToInt32(inicio);

            if (final == "AM")
            {
                if (numero == 12)
                {
                    return "00" + s.Substring(2, s.Length - 4);
                }
                else
                {
                    return s.Substring(0, s.Length - 2);
                }
            }
            else
            {
                string newInicio;
                if (numero == 12)
                {
                    newInicio = numero.ToString();
                    return newInicio + s.Substring(2, 6);
                }
                else
                {
                    numero = numero + 12;
                    newInicio = numero.ToString();
                    return newInicio + s.Substring(2, 6);
                }
            }

        }
    }
}
