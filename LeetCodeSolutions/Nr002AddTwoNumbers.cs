/*
2. AddTwoNumbers
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit.
Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

namespace LeetCodeSolutions
{
    class Nr002AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
 
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            var newListPreHead = new ListNode(0);
            var newListPointer = newListPreHead;
            var l1Pointer = l1;
            var l2Pointer = l2;
            int carry = 0;
            while (carry > 0 || l1Pointer != null || l2Pointer != null)
            {
                int currentValue = 0;
                if (l1Pointer != null)
                    currentValue += l1Pointer.val;
                if (l2Pointer != null)
                    currentValue += l2Pointer.val;
                currentValue += carry;
                carry = 0;
                if (currentValue > 9)
                {
                    carry++;
                    currentValue -= 10;
                }
                newListPointer.next = new ListNode(currentValue);
                newListPointer = newListPointer.next;
                if (l1Pointer != null)
                    l1Pointer = l1Pointer.next;
                if (l2Pointer != null)
                    l2Pointer = l2Pointer.next;
            }
            return newListPreHead.next;
        }
    }
}
