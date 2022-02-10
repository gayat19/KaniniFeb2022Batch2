using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstndingClassApp
{
    class UnderstandingArray
    {
        public void WorkingWithArray()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100, 1000);
            }
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public void WorkingWithTwoDimArray()
        {
            string[,] students = new string[2, 3];
            for (int i = 0; i < students.GetLength(1); i++)
            {
                Console.WriteLine("Please enter the student name");
                students[0, i] = "S00" + (i + 1);
                students[1, i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(students[0,i]+"\t"+students[1,i]);
            }
        }
        public void UnderstandingJaggedArray()
        {
            int[][] scores = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                scores[i] = new int[(i + 1) + i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    scores[i][j] = i * j + 80;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write(scores[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
