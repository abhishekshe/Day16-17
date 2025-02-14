﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public string data;
        public int idata;
        public Node next;

        public Node(string data)
        {
            this.data = data;
            next = null;
        }
        public Node(int data)
        {
            this.idata = data;
            next = null;
        }
    }
    class LinkList
    {
        Node head;
        public void InsertFront(string data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public bool InsertSorted(int data)
        {
            Node newNode = new Node(data);
            Node current = head;
            Node previous = head;
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
                return true;
            }
            else
            {
                if (current.idata >= newNode.idata)
                {
                    newNode.next = head;
                    head = newNode;
                    Console.WriteLine(current.data);
                    return true;
                }
                while (current.idata < newNode.idata)
                {
                    if (current.next == null)
                    {
                        break;
                    }
                    previous = current;
                    current = current.next;
                }
                if (previous.idata < newNode.idata && newNode.idata < current.idata)
                {
                    newNode.next = previous.next;
                    previous.next = newNode;
                    return true;
                }
                else
                {
                    newNode.next = current.next;
                    current.next = newNode;
                    return true;
                }
            }
        }
       
        public bool InsertNextTOKey(string key, string data)
        {
            Node current = head;
            while (current.data != key)
            {
                if (current.next == null)
                {
                    break;
                }
                current = current.next;
            }
            if (current.data == key)
            {
                Node newNode = new Node(data);
                newNode.next = current.next;
                current.next = newNode;
                Console.WriteLine("element is added to list");
                return true;
            }
            else
            {
                Console.WriteLine("key is not in the list");
                return false;
            }
        }
        
        public void DisplayIntList()
        {
            Node current = head;
            if (head != null)
            {
                while (current != null)
                {
                    Console.Write(current.idata + "-->");
                    current = current.next;
                }
                Console.Write("null");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
       
        public void DisplayStringList()
        {
            Node current = head;
            if (head != null)
            {
                while (current != null)
                {
                    Console.Write(current.data + "-->");
                    current = current.next;
                }
                Console.Write("null");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
       
        public string ReturnString()
        {
            string stringText = "";
            Node current = head;
            if (head != null)
            {
                stringText += current.data;
                current = current.next;
                while (current != null)
                {
                    stringText = stringText + " " + current.data;
                    current = current.next;
                }
                return stringText;
            }
            else
            {
                Console.WriteLine("List is empty");
                return null;
            }
        }
       
        public string ReturnNumberString()
        {
            string stringText = "";
            Node current = head;
            if (head != null)
            {
                stringText += current.idata;
                current = current.next;
                while (current != null)
                {
                    stringText = stringText + " " + current.idata;
                    current = current.next;
                }
                return stringText;
            }
            else
            {
                Console.WriteLine("List is empty");
                return null;
            }
        }
       
        public bool Search(string key)
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty so none element deleted");
                return false;
            }
            while (current.data != key)
            {
                if (current.next == null)
                {
                    break;
                }
                current = current.next;
            }
            if (current.data == key)
            {
                Console.WriteLine("element found in list");
                return true;
            }
            else
            {
                Console.WriteLine("element is not in list");
                return false;
            }
        }
        
        public bool SearchInt(int key)
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty so none element deleted");
                return false;
            }
            while (current.idata != key)
            {
                if (current.next == null)
                {
                    break;
                }
                current = current.next;
            }
            if (current.idata == key)
            {
                Console.WriteLine("element found in list");
                return true;
            }
            else
            {
                Console.WriteLine("element is not in list");
                return false;
            }
        }

        public void DeleteFront()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty so none element deleted");
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                head.data = head.next.data;
                head.next = head.next.next;
            }
        }
     
        public bool DeleteKeyElement(string key)
        {
            Node current = head;
            Node previous = head;
            if (current.data == key)
            {
                head.data = head.next.data;
                head.next = head.next.next;
                Console.WriteLine("1st element deleted from the list");
                return true;
            }
            else
            {
                current = current.next;
            }
            while (current.data != key)
            {
                if (current.next == null)
                {
                    break;
                }
                previous = current;
                current = current.next;
            }
            if (current.data == key)
            {
                previous.next = current.next;
                Console.WriteLine("element  deleted from the list");
                return true;
            }
            else
            {
                Console.WriteLine("element is not in list");
                return false;
            }
        }
       
        public bool DeleteIntKeyElement(int key)
        {
            Node current = head;
            Node previous = head;
            if (current.idata == key)
            {
                head.data = head.next.data;
                head.next = head.next.next;
                Console.WriteLine("1st element deleted from the list");
                return true;
            }
            else
            {
                current = current.next;
            }
            while (current.idata != key)
            {
                if (current.next == null)
                {
                    break;
                }
                previous = current;
                current = current.next;
            }
            if (current.idata == key)
            {
                previous.next = current.next;
                Console.WriteLine("element  deleted from the list");
                return true;
            }
            else
            {
                Console.WriteLine("element is not in list");
                return false;
            }
        }
    }
}