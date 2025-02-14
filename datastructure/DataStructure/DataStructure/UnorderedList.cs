﻿using System;
using System.IO;
using System.Text;

namespace LinkedList
{
    class UnorderedList
    {
        public void Unorderd()
        {
            string text = File.ReadAllText(@"C:\Users\dell\source\linked.txt", Encoding.UTF8);
            string[] stringSeparator = new string[] { " " };
            string[] textArray;
            textArray = text.Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries);
            LinkList list = new LinkList();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.DisplayStringList();
            Console.WriteLine("Enter a string which you want to be found:");
            string searchString = Console.ReadLine();
            if (list.Search(searchString))
            {
                list.DeleteKeyElement(searchString);
            }
            else
            {
                list.InsertFront(searchString);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\dell\source\linked.txt", textFile);
          
            list.DisplayStringList();

        }
    }
}