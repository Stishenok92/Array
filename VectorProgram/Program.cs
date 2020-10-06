using System.ComponentModel.DataAnnotations;
using static VectorLibrary.Vector;
using System;

namespace VectorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Task \"Array with double numbers\"");
                Console.WriteLine();
                int size = GetInt("Enter size array: ");
                double min = GetDouble("Enter min number to initialize (double): ");
                double max = GetDouble("Enter max number to initialize (double): ");
                double[] array = GetArrayDoubleRandomFilled(min, max, size);
                Console.WriteLine();
                ShowArrayDoubleIndexAndData(array);
                Console.WriteLine();
                Console.WriteLine("Sum of negative numbers between maximum and minimum numbers: "
                                  + SumNegativeDoubleNumberBetweenMaxAndMin(array));
                Console.WriteLine("Mul numbers between maximum and minimum numbers: "
                                  + MulDoubleNumberBetweenMaxAndMin(array));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}