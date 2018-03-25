/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        while( head!=null ){
            if( head.val!=val ){
                break;
            }
            head = head.next;
        }
        ListNode temp = head;
        if( temp==null )
            return null;
        while( temp.next!=null ){
            if( temp.next.val==val )
                temp.next = temp.next.next;
            else
                temp = temp.next;
        }
        return head;
    }
}