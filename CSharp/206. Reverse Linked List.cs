/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode now,next,last;
        now = head;
        next = head;
        last = null;
        while( next != null ){
            next = now.next;
            now.next = last;
            last = now;
            now = next;
        }
        return last;
    }
}