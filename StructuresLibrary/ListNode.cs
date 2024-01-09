namespace StructuresLibrary;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static bool operator ==(ListNode b1, ListNode b2)
    {
        if ((object)b1 == null)
            return (object)b2 == null;

        return b1.Equals(b2);
    }

    public static bool operator !=(ListNode b1, ListNode b2)
    {
        return !(b1 == b2);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
            return false;

        ListNode? currentNode1 = this;
        ListNode? currentNode2 = (ListNode)obj;

        while (true)
        {
            if (currentNode1 is null && currentNode2 is null)
            {
                return true;
            }

            if ((currentNode1 is null && currentNode2 is not null)
                || (currentNode1 is not null && currentNode2 is null))
            {
                return false;
            }

            if (currentNode1!.val != currentNode2!.val)
            {
                return false;
            }

            currentNode1 = currentNode1.next;
            currentNode2 = currentNode2.next;
        }
    }

    // ListNode is not supposed to be on a hashlist
    public override int GetHashCode()
    {
        return 0;
    }
}
