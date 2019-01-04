/*
21. Merge Two Sortes Lists
Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
*/

namespace LeetCodeSolutions
{
    class Nr021MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            ListNode pointerl1 = l1;
            ListNode pointerl2 = l2;
            ListNode newHead = l1.val <= l2.val ? l1 : l2;
            ListNode newPointer = newHead;
            if (l1.val <= l2.val)
                pointerl1 = pointerl1.next;
            else
                pointerl2 = pointerl2.next;

            while (pointerl1 != null && pointerl2 != null)
            {
                if (pointerl1.val <= pointerl2.val)
                {
                    newPointer.next = pointerl1;
                    newPointer = newPointer.next;
                    pointerl1 = pointerl1.next;
                }
                else
                {
                    newPointer.next = pointerl2;
                    newPointer = newPointer.next;
                    pointerl2 = pointerl2.next;
                }
            }

            if (pointerl1 != null)
                newPointer.next = pointerl1;

            if (pointerl2 != null)
                newPointer.next = pointerl2;

            return newHead;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
