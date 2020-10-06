using static VectorLibrary.Vector;
using System;

namespace VectorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task \"Array\"\n");

            int size = GetIntNatural("Enter size array: ");
            int[] array = GetArrayRandomFilledIntNatural(MIN_NATURAL_NUMBER, MAX_NATURAL_NUMBER, size);
            ShowArray(array, "Array has form: ");

        }
    }
}