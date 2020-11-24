using System;

namespace ArrayDemoContinued
{
    class Program
    {
        public static int[] CountAlfabetLetters(string text)
        {
            // Hello World from CSharp !
            text = text.ToLower();

            int[] frequencyAlfabet = new int[26];
            foreach(var letter in text)
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    int index = letter - 'a';       // 0 => 25
                    frequencyAlfabet[index]++;
                }
            }

            return frequencyAlfabet;
        }


        public static bool DoesContain(int[] values, int value)
        {
            foreach (var item in values)
            {
                if (item == value) return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] numbers =
            {
                12, 232, 34, 35, 100
            };

            Console.WriteLine("With for-loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"\t{numbers[i]}");
            }

            Console.WriteLine("\nWith foreach:");
            foreach (var number in numbers)
            {
                Console.WriteLine($"\t{number}");
                // number = number * 2;     // <=== CANNOT CHANGE NUMBER !
            }

            Console.WriteLine("Does contain 35? " + DoesContain(numbers, 35));
            Console.WriteLine("Does contain 101? " + DoesContain(numbers, 101));

            // 2D array
            //int[,] matrix = new int[2, 3];
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            Console.WriteLine("\n2D array");
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.WriteLine(matrix[r, c]);
                }
            }

            int[] freqTable = CountAlfabetLetters("Hello World from CSharp !");
            // a: 12
            // b: 0
            for (int i = 0; i < freqTable.Length; i++)
            {
                Console.WriteLine($"{Convert.ToChar('a' + i)}: {freqTable[i]}");
            }
        }
    }
}
