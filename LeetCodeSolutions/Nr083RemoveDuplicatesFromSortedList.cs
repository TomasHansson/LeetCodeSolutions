/*
83. Remove Duplicates from Sorted List
Given a sorted linked list, delete all duplicates such that each element appear only once.
*/

namespace LeetCodeSolutions
{
    class Nr083RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode headToReturn = head;
            ListNode currentValuePointer = head;
            ListNode pointer = head.next;
            int currentValue = head.val;
            while (true)
            {
                if (pointer.val == currentValue && pointer.next == null)
                {
                    currentValuePointer.next = null;
                    break;
                }
                else if (pointer.val == currentValue)
                {
                    pointer = pointer.next;
                }
                else if (pointer.val != currentValue && pointer.next == null)
                {
                    currentValuePointer.next = pointer;
                    break;
                }
                else if (pointer.val != currentValue)
                {
                    currentValuePointer.next = pointer;
                    currentValuePointer = pointer;
                    currentValue = pointer.val;
                    pointer = pointer.next;
                }
            }
            return headToReturn;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
