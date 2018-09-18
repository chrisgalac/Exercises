/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    public int listToInt(ListNode n){
        int rv = 0;
        int multiplier = 1;
        ListNode curr = n;
        
        while(curr != null){
            rv += (curr.val * multiplier);
            multiplier *= 10;
            curr = curr.next;
        }
        
        return rv;
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int a = listToInt(l1);
        int b = listToInt(l2);
        int sum = a + b;
        
        if(sum == 0) return new ListNode(0);
        
        ListNode rv = new ListNode(sum % 10);
        ListNode tail = rv;
        sum /= 10;
        
        while(sum > 0){
            tail.next = new ListNode(sum % 10);
            tail = tail.next;
            sum /= 10;
        }
        
        return rv;
    }
}