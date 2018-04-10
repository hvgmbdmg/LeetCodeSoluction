/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        //Try again;
        ListNode pointerOne = headA;
        ListNode pointerTwo = headB;
        
        if( pointerOne==null || pointerTwo==null )
            return null;
            
        while( pointerOne!=null && pointerTwo!=null && pointerOne!=pointerTwo ){
            //null == null
            pointerOne = pointerOne.next;
            pointerTwo = pointerTwo.next;
            
            if( pointerOne==pointerTwo )
                return pointerOne;
            
            if( pointerOne==null )
                pointerOne = headB;
            if( pointerTwo==null )
                pointerTwo = headA;
        }
        
        return pointerOne;
    }
}