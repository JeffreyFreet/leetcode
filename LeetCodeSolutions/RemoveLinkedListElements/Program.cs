using System;

namespace RemoveLinkedListElements
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution(new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))))), 6);
        }

        static void Solution(ListNode head, int val)
        {
            ListNode runner = head;
            ListNode previousNode = runner;

            while(runner != null)
            {
                if(runner.val == val)
                {
                    previousNode = runner;
                    runner = runner.next;
                }
            }

            WriteSolution(head);
        }

        static void WriteSolution(ListNode head)
        {
            ListNode runner = head;

            while(runner.next != null)
            {
                Console.WriteLine(runner.val);
            }
        }
    }
}
