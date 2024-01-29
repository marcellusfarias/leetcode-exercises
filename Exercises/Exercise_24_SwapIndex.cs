using StructuresLibrary;

namespace Exercises;

public partial class Exercise
{
    // Given a linked list, swap every two adjacent nodes and return its head.
    // You must solve the problem without modifying the values in the list's
    // nodes (i.e., only nodes themselves may be changed.)
    public static ListNode? SweepPairs(ListNode head)
    {
        if (head is null)
        {
            return null; 
        }

        ListNode? currentNode = head;

        while(currentNode is not null && currentNode.next is not null)
        {
            var temp = currentNode.val;
            currentNode.val = currentNode.next.val;
            currentNode.next.val = temp;

            currentNode = currentNode.next.next;
        }
        
        return currentNode;
    }
}
