using System.ComponentModel.DataAnnotations;
using System;

namespace VectorLibrary
{
    public class Vector
    {
        private const int MIN_SIZE_ARRAY = 1;
        private const int NUMBER_OF_ROUND = 2;
        private const int MIN_NUMBER_OF_ELEMENT = 1;

        public static int GetInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        public static double GetDouble(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }

        private static bool ValidationSizeArray(int size)
        {
            return size >= MIN_SIZE_ARRAY;
        }

        private static double InitDoubleRandom(double min, double max)
        {
            if (min > max)
            {
                throw new ValidationException();
            }

            Random random = new Random();
            return Math.Round((random.NextDouble() * (max - min) + min), NUMBER_OF_ROUND);
            ;
        }

        private static void InitArrayDoubleRandom(double min, double max, ref double[] array)
        {
            if (min > max)
            {
                throw new ValidationException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = InitDoubleRandom(min, max);
            }
        }

        public static double[] GetArrayDoubleRandomFilled(double min, double max, int size)
        {
            if (!ValidationSizeArray(size) || min > max)
            {
                throw new ValidationException();
            }

            double[] temp = new double[size];
            InitArrayDoubleRandom(min, max, ref temp);
            return temp;
        }

        private static void ShowArrayIndex(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("[" + i + "]" + "\t");
            }
        }

        private static void ShowArrayDoubleData(double[] array)
        {
            foreach (var t in array)
            {
                Console.Write(t + "\t");
            }
        }

        public static void ShowArrayDoubleIndexAndData(double[] array)
        {
            ShowArrayIndex(array.Length);
            Console.WriteLine();
            ShowArrayDoubleData(array);
            Console.WriteLine();
        }

        private static int FindIndexMinDoubleNumber(double[] array)
        {
            int index = 0;
            double number = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < number)
                {
                    index = i;
                    number = array[i];
                }
            }

            return index;
        }

        private static int FindIndexMaxDoubleNumber(double[] array)
        {
            int index = 0;
            double number = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    index = i;
                    number = array[i];
                }
            }

            return index;
        }

        private static bool IsNegativeDoubleNumber(double number)
        {
            return number < 0;
        }

        private static bool ValidationIndexesForOperation(ref int minIndex, ref int maxIndex)
        {
            bool flag = true;

            if (Math.Abs(maxIndex - minIndex) > MIN_NUMBER_OF_ELEMENT)
            {
                if (minIndex > maxIndex)
                {
                    Swap(ref minIndex, ref maxIndex);
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        private static double SumNegativeDoubleNumbers(double[] array, int minIndex, int maxIndex)
        {
            double sum = 0;

            if (!ValidationIndexesForOperation(ref minIndex, ref maxIndex))
            {
                return sum;
            }

            for (int i = ++minIndex; i < maxIndex; i++)
            {
                if (IsNegativeDoubleNumber(array[i]))
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        private static double MulDoubleNumbers(double[] array, int minIndex, int maxIndex)
        {
            if (!ValidationIndexesForOperation(ref minIndex, ref maxIndex))
            {
                return 0;
            }

            double mul = 1;

            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                mul *= array[i];
            }

            return mul;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        public static double SumNegativeDoubleNumberBetweenMaxAndMin(double[] array)
        {
            int minIndex = FindIndexMinDoubleNumber(array);
            int maxIndex = FindIndexMaxDoubleNumber(array);
            return Math.Round(SumNegativeDoubleNumbers(array, minIndex, maxIndex), NUMBER_OF_ROUND);
        }

        public static double MulDoubleNumberBetweenMaxAndMin(double[] array)
        {
            int minIndex = FindIndexMinDoubleNumber(array);
            int maxIndex = FindIndexMaxDoubleNumber(array);
            return Math.Round(MulDoubleNumbers(array, minIndex, maxIndex), NUMBER_OF_ROUND);
        }
    }
}