using System;
using System.Collections.Generic;

namespace ConsoleApp5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int[] first = {1, 2, 1};
            int[] second = {3, 2};

            list.AddRange(first);
            list.AddRange(second);

            Console.WriteLine("Изначальные массивы");
            WriteList(list);
            list.Sort();
            Console.WriteLine();

            for (int i = 1; i < list.Count; i++)
            {
                if(list[i -1] == list[i])
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine("Отсортированный массив без повторений");
            WriteList(list);            
        }

        static void WriteList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}
