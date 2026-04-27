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
public class Solution 
{
    // Task 23 | Hard
    public ListNode MergeKLists(ListNode[] lists) 
    {
        var pq = new PriorityQueue<ListNode, int>();

        foreach (var list in lists)
        {
            if (list != null)
            pq.Enqueue(list, list.val);
        }
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (pq.Count > 0)
        {
            ListNode node = pq.Dequeue();
            current.next = node;
            current = current.next;

            if (node.next != null)
                pq.Enqueue(node.next, node.next.val);
        }
        return dummy.next;
    }
}