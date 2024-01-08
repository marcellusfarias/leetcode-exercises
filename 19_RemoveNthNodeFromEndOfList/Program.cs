// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// params
ListNode head = new ListNode();
int n = 2;
var nodeArray = new int[] { 1, 2 };
head.AddFromArray(nodeArray);

// code
if(head == null)
{
    return; // return null;
}

var current = head;
int count = 1;
while(current.next != null)
{
    current = current.next;
    count++;
}

current = head;
var elementToRemoveIndex = count - n;

if (elementToRemoveIndex == 0)
    return; //return head.next;

for (int i = 0; i < elementToRemoveIndex - 1; i++)
{
    current = current.next;
}

if (current.next.next != null)
    current.next = current.next.next;
else
    current.next = null;

var xys = 1;
//Others
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

internal static class ListNodeHelper
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




