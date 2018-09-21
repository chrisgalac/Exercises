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
        if(n == 1 && head.next == null) return null;
        
        ListNode ahead = head;
        while(n > 0){
            ahead = ahead.next;
            n--;
        }
        
        if(ahead == null){
            head.val = head.next.val;
            head.next = head.next.next;
            return head;
        }
        
        ListNode behind = head;
        while(ahead.next != null){
            ahead = ahead.next;
            behind = behind.next;
        }
        behind.next = behind.next.next;
        
        return head;
        
    }
}