/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var curr=head;
        while(curr.next!=null){
            var firstNumber=curr.val;
            var secondNumber=curr.next.val;
            var newNode=new ListNode((int)BigInteger.GreatestCommonDivisor(firstNumber,secondNumber),curr.next);
            curr.next=newNode;
            curr=curr.next.next;
            
        }
        return head;
    }
}