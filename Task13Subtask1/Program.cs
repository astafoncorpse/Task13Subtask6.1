using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Task13Subtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\SuperUser\\Downloads\\Text1.txt");
            CreateListT(text);

            CreateLinkedList(text);
        }

        static void CreateListT(string text)
        {
            Console.WriteLine("\nCreateListT начинает свою работу");

            char[] delimetrs = new char[] { ' ', '\r', '\n', '.', ',' };

            var wordslist = text.Split(delimetrs, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newElements = text.Split(delimetrs, StringSplitOptions.RemoveEmptyEntries).ToList();

            var timer = new Stopwatch();
            timer.Start();

            wordslist.AddRange(newElements);

            timer.Stop();
            Console.WriteLine("время работы " + timer.ElapsedMilliseconds);

            Console.WriteLine("CreateListT завершил сврю работу");

            Console.WriteLine("CreateLinkedList начнет свою работу через 5 сек");
            Thread.Sleep(5000);
        }
        static void CreateLinkedList(string text)
        {
            Console.WriteLine("\nCreateLinkedList начал свою работу");

            char[] delimetrs = new char[] { ' ', '\r', '\n', '.', ',' };

            var wordslist = text.Split(delimetrs, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newElements = text.Split(delimetrs, StringSplitOptions.RemoveEmptyEntries).ToList();

            var linkedlist = new LinkedList<string>(wordslist);

            var timer = new Stopwatch();
            timer.Start();

            foreach (var el in newElements)
            {
                linkedlist.AddAfter(linkedlist.First, el);
            }
            timer.Stop();
            Console.WriteLine("Время работы " + timer.ElapsedMilliseconds);

            Console.WriteLine("CreateLinkList окончил свою работу");
            Console.ReadKey();


        }
    }
}