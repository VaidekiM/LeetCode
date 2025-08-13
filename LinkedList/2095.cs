/* 2095. Delete the middle node of a linked list */
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
    public ListNode DeleteMiddle(ListNode head) {
        int length = GetLength(head);
        int middle = length/2;
        ListNode newNode = head;
        if (middle == 0)
            return head.next;
    
        for (int i = 0; i < middle - 1; i++)
        {
            newNode = newNode.next;
        }
        if (newNode != null && newNode.next != null)
            newNode.next = newNode.next.next;
            
        return head;
    }
    public int GetLength(ListNode head)
    {  
        int count = 0;
        ListNode current = head;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }
}