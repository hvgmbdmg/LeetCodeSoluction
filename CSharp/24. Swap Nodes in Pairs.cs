/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if( head==null || head.next==null )
            return head;
        
        ListNode first = null;
        ListNode second = null;
        ListNode result = new ListNode(0);
        ListNode current = result;
        result.next = head;
        
        while( current.next!=null && current.next.next!=null ){
            //Console.WriteLine( current.val );
            first = current.next;
            second = current.next.next;
            
            first.next = second.next;
            current.next = second;
            second.next = first;
            
            current = current.next.next;
        }
        
        return result.next;
    }
}