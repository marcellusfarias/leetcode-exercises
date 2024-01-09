namespace StructuresLibrary;

public static class ListNodeHelper
{
    public static ListNode? CreateFromArray(int[] nodes)
    {
        if (nodes.Length == 0)
            return null; 

        var head = new ListNode();
        head.val = nodes[0];
        var current = head;

        foreach (int node in nodes.Skip(1))
        {
            current.next = new ListNode(node);
            current = current.next;
        }

        return head;
    }
}