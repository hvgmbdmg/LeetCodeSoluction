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
        ListNode retList = new ListNode(0);
        ListNode head = retList;
        int sum = 0;
        
        while( l1!=null || l2!=null ){
            
            if( l1!=null ){
                sum += l1.val;
                l1 = l1.next;
            }
            if( l2!=null ){
                sum += l2.val;
                l2 = l2.next;
            }
            retList.next = new ListNode(sum%10);
            retList = retList.next;
            sum /= 10;
        }
        if( sum!=0 )
            retList.next = new ListNode(sum%10);
        
        return head.next;
    }
}