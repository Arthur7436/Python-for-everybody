using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class NewClass
    {
        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

        public void PrintList()
        {
            Node current = Head;

            while (current != null)
            {
                System.Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode prehead = new ListNode(-1);
                ListNode prev = prehead;

                while (list1 != null && list2 != null)
                {
                    if (list1.val <= list2.val)
                    {
                        prev.Next = list1.val;
                    }
                    else
                    {
                        prev.Next = list2.val;
                    }
                }


            }
        }
    }
}