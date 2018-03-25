/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode lastPos = head;
        
        while( lastPos != null ){
            if( lastPos.next == null )
                break;
            if( lastPos.val == lastPos.next.val )
                lastPos.next = lastPos.next.next;
            else
                lastPos = lastPos.next;
        }
        return head;
    }
    
}