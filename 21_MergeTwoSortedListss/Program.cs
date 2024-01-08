// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var list1 = new ListNode();
list1.AddFromArray(new int[] { 1, 2, 4 });

var list2 = new ListNode();
list2.AddFromArray(new int[] { 1, 3, 4 });

var result = MergeTwoLists(list1, list2);
var x = 1;

static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if(list1.val == 0 && list1.next == null
        && list2.val == 0 && list2.next == null)
    {
        return new ListNode();
    }

    List<int> ints = new List<int>();
    var current = list1;

    while(current != null)
    {
        ints.Add(current.val);
        current = current.next;
    }

    current = list2;
    while(current != null)
    {
        ints.Add(current.val);
        current = current.next;
    }

    if (ints.Count == 0)
        return new ListNode();

    var returnNode = new ListNode();    
    returnNode.AddFromArray(ints.OrderBy(x => x).ToArray());
    return returnNode;
}

internal class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

static class ListNodeHelper
{
    internal static void AddFromArray(this ListNode head, int[] nodes)
    {
        head.val = nodes[0];
        var current = head;

        foreach (int node in nodes.Skip(1))
        {
            current.next = new ListNode(node);
            current = current.next;
        }
    }
}