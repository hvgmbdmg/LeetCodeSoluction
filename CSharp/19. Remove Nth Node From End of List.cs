/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode Result = new ListNode(0);
        Result.next = head;
        ListNode First = head;
        ListNode Second = Result;
        
        for( int i=1;i<n;i++ )
            First = First.next;

        while( First.next!=null ){
            First = First.next;
            Second = Second.next;
        }
        Second.next = Second.next.next;
        return Result.next;
    }
}