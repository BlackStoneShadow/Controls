using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу, которая из иеющегося массива строк формирует массив из строк,
//длина которых меньше или равна трем симвалам. Первоначальный массив вводится с клавиатуры.
//["hello", "2", "world", ":-"] -> ["2", ":-"]
namespace Task01
{
    class Program
    {
        static string[] Read(string Caption)
        {
            Console.Write($"{Caption}:");

            return Console.ReadLine().Split(',');
        }
        static string[] Convert(string[] Array)
        {
            return Array.Where(Item=>Item.Length < 4).ToArray();
        }
        static void Print(string[] Array)
        {
            Console.Write("[{0}]->[{1}]", string.Join(",", Array), string.Join(",", Convert(Array)));
        }
        static void Main(string[] args)
        {
            Print(Read("Input array"));

            Console.ReadKey();
        }
    }
}
