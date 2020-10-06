using System.ComponentModel.DataAnnotations;
using System;


namespace VectorLibrary
{
    public class Vector
    {
        public const int MIN_NATURAL_NUMBER = 1;
        public const int MAX_NATURAL_NUMBER = 100;

        public static int GetInt(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        public static bool ValidationIntNatural(int size)
        {
            return size >= MIN_NATURAL_NUMBER;
        }

        public static int GetIntNatural(string msg)
        {
            int size = GetInt(msg);

            if (!ValidationIntNatural(size))
            {
                throw new ValidationException();
            }

            return size;
        }

        public static int[] GetArrayInt(int size)
        {
            if (!ValidationIntNatural(size))
            {
                throw new ValidationException();
            }

            return new int[size];
        }

        public static int InitIntRandom(int min, int max)
        {
            if (min > max)
            {
                throw new ValidationException();
            }
            
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        public static void InitArrayIntRandom(int min, int max, ref int[] array)
        {
            if (min > max)
            {
                throw new ValidationException();
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = InitIntRandom(min, max);
            }
        }

        public static int[] GetArrayRandomFilledIntNatural(int min, int max, int size)
        {
            if (!ValidationIntNatural(size) || min > max)
            {
                throw new ValidationException();
            }
            
            int[] temp = new int[size]; 
            InitArrayIntRandom(min, max, ref temp);
            return temp;
        }

        public static void ShowArrayIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + i + "]" + "\t");
            }
        }
        
        public static void ShowArrayData(int[] array)
        {
            foreach (var t in array)
            {
                Console.Write(t + "\t");
            }
        }

        public static void ShowArray(int[] array, string msg)
        {
            Console.WriteLine(msg);
            ShowArrayIndex(array);
            Console.WriteLine();
            ShowArrayData(array);
        }
    }
}