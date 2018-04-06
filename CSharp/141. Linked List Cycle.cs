/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode runner = head;
        ListNode walker = head;
        
        if( head==null )
            return false;
        
        while( runner.next!=null && runner.next.next!=null ){
            walker = walker.next;
            runner = runner.next.next;
            if( walker == runner )
                return true;
        }
        
        return false;
    }
}