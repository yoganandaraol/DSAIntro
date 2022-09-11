﻿using System;

namespace _107_LinkedListBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode inputA = CreateLinkedList();
            PrintLinkedList(inputA);
            Console.WriteLine(SearchForValue(inputA, new Random().Next(100, 110)) == 1 ? "Passed" : "Failed");
            Console.WriteLine(SearchForValue(inputA, new Random().Next(99)) == 0 ? "Passed" : "Failed");

            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 4));
            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 6));
            PrintLinkedList(InsertNodeAt(null, 10, 6));
            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 16));
        }

        private static ListNode CreateLinkedList()
        {
            var inputA = new ListNode(100);
            var temp = inputA;
            for (int i = 1; i <= 10; i++)
            {
                temp.next = new ListNode(temp.val + 1);
                temp = temp.next;
            }

            return inputA;
        }

        static void PrintLinkedList(ListNode A)
        {
            ListNode temp = A;
            while (temp != null)
            {
                Console.Write(string.Format("{0} ", temp.val));
                temp = temp.next;
            }
            Console.WriteLine();
        }

        static int SearchForValue(ListNode A, int B)
        {
            ListNode temp = A;
            while(temp != null)
            {
                if (temp.val == B)
                {
                    return 1;
                }
                temp = temp.next;
            }
            return 0;
        }

        static ListNode InsertNodeAt(ListNode A, int B, int C)
        {
            var insertNode = new ListNode(B);
            ListNode temp = A;

            if (C == 0 || temp == null)
            {
                insertNode.next = A;
                return insertNode;
            }

            for (int i = 1; i < C; i++)
            {
                if (temp.next == null) break;
                temp = temp.next;
            }

            insertNode.next = temp.next;
            temp.next = insertNode;

            return A;
        }
    }

    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }
}
