using System;

namespace _107_LinkedListBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------- Printing List ---------------");
            ListNode inputA = CreateLinkedList();
            PrintLinkedList(inputA);
            PrintLinkedList(CreateLinkedListDesc());
            PrintLinkedList(CreateLinkedList(16));

            Console.WriteLine("---------------- Search ---------------");
            Console.WriteLine(SearchForValue(inputA, new Random().Next(100, 110)) == 1 ? "Passed" : "Failed");
            Console.WriteLine(SearchForValue(inputA, new Random().Next(99)) == 0 ? "Passed" : "Failed");

            Console.WriteLine("---------------- Insert ---------------");

            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 4));
            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 6));
            PrintLinkedList(InsertNodeAt(null, 10, 6));
            PrintLinkedList(InsertNodeAt(CreateLinkedList(), 10, 16));

            Console.WriteLine("---------------- List Order ---------------");

            Console.WriteLine(CheckLinkedListInAscendingOrderOrNot(CreateLinkedList()));
            Console.WriteLine(CheckLinkedListInAscendingOrderOrNot(CreateLinkedListDesc()));

            Console.WriteLine("---------------- Remove At ---------------");

            PrintLinkedList(DeleteNodeAt(CreateLinkedList(), 4));
            PrintLinkedList(DeleteNodeAt(CreateLinkedList(), 6));
            PrintLinkedList(DeleteNodeAt(CreateLinkedList(), 12));
            PrintLinkedList(DeleteNodeAt(CreateLinkedList(), 11));
            PrintLinkedList(DeleteNodeAt(CreateLinkedList(), 10));
            PrintLinkedList(CreateLinkedList(2));
            PrintLinkedList(DeleteNodeAt(CreateLinkedList(2), 0));
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

        private static ListNode CreateLinkedListDesc()
        {
            var inputA = new ListNode(100);
            var temp = inputA;
            for (int i = 1; i <= 10; i++)
            {
                temp.next = new ListNode(temp.val - 1);
                temp = temp.next;
            }

            return inputA;
        }

        private static ListNode CreateLinkedList(int n)
        {
            var inputA = new ListNode(100);
            var temp = inputA;
            for (int i = 1; i < n; i++)
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

        // Delete at Bth Node
        static ListNode DeleteNodeAt(ListNode A, int B)
        {
            if (A == null) return null;
            if (B == 0 && A.next != null) return A.next;

            var temp = A;

            for (int i = 1; i < B; i++)
            {
                if (temp.next == null) break;

                temp = temp.next;
            }

            if (temp == null || temp != null && temp.next == null)
            {
                temp = null;
            }
            else if (temp != null && temp.next != null)
            {
                temp.next = temp.next.next;
            }

            return A;
        }

        static int CheckLinkedListInAscendingOrderOrNot(ListNode A)
        {
            ListNode temp = A;
            var max = int.MinValue;
            while (temp != null)
            {
                if (temp.val < max) return 0;
                else
                    max = temp.val;

                temp = temp.next;
            }

            return 1;
        }

        
    }

    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }
}
