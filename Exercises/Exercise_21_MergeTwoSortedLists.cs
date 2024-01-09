using StructuresLibrary;
namespace Exercises;

public partial class Exercise
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1.val == 0 && list1.next == null
            && list2.val == 0 && list2.next == null)
        {
            return new ListNode();
        }

        List<int> ints = new List<int>();
        var current = list1;

        while (current != null)
        {
            ints.Add(current.val);
            current = current.next;
        }

        current = list2;
        while (current != null)
        {
            ints.Add(current.val);
            current = current.next;
        }

        if (ints.Count == 0)
            return new ListNode();

        var returnNode = ListNodeHelper.CreateFromArray(ints.OrderBy(x => x).ToArray());
        return returnNode;
    }

}
