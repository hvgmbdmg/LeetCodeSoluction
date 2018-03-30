/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        Stack<int> listNodeStack1 = new Stack<int>();
        Stack<int> listNodeStack2 = new Stack<int>();
        
        ListNode temp = l1;
        while( temp!= null ){
            listNodeStack1.Push(temp.val);
            temp = temp.next;
        }
        temp = l2;
        while( temp!= null ){
            listNodeStack2.Push(temp.val);
            temp = temp.next;
        }
        
        int sum = 0;
        ListNode head = new ListNode(0);
        while( listNodeStack1.Count!=0 || listNodeStack2.Count!=0 ){
            if( listNodeStack1.Count!=0 )
                sum += listNodeStack1.Pop();
            if( listNodeStack2.Count!=0 )
                sum += listNodeStack2.Pop();
            head.val = sum%10;
            ListNode newHead = new ListNode(sum/10);
            newHead.next = head;
            head = newHead;
            sum = newHead.val;
        }
        
        
        return head.val==0 ? head.next : head;
    }
}