using StructuresLibrary;

namespace Exercises;

public partial class Exercise
{
    public static ListNode? MergeKLists(ListNode?[] lists)
    {
        if (lists is null || lists.Length == 0)
            return null;

        // Easy solution
        // Add all elements to a list, sort it and create a new ListNode
        // Total time: 92ms (beats 78%)
        // Total memory: 47.30MB (beats 7%)
        var aggregatedList = new List<int>();

        foreach (ListNode? node in lists)
        {
            if (node is null)
                continue;

            var currentNode = node;

            do
            {
                aggregatedList.Add(currentNode.val);
                currentNode = currentNode.next;
            } while (currentNode is not null);
        }

        return ListNodeHelper.CreateFromArray(aggregatedList.Order().ToArray());
    }
}
