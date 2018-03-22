/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        //Try faster solution next time
        ListNode mergeList = new ListNode(0);
        ListNode nowListPointer = mergeList;
        
        while( l1!=null && l2!=null ){
            if( l1.val <= l2.val ){
                nowListPointer.next = l1;
                l1 = l1.next;
                nowListPointer = nowListPointer.next;
            }
            else{
                nowListPointer.next = l2;
                l2 = l2.next;
                nowListPointer = nowListPointer.next;
            }
        }

        if( l1==null )
            nowListPointer.next = l2;
        else
            nowListPointer.next = l1;
        
        return mergeList.next;
    }
}