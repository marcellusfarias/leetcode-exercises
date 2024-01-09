using StructuresLibrary;

namespace Exercises;

public partial class Exercise
{
    public static ListNode? MergeKLists(ListNode?[] lists)
    {
        if (lists is null)
            return null;

        var list = lists.ToList();
        if (list.All(x => x is null))
            return null;

        // Easy solution
        // Add all elements to a list, sort it and create a new ListNode
        var aggregatedList = new List<int>();

        foreach (ListNode? node in list)
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

        aggregatedList = aggregatedList.Order().ToList();

        return ListNodeHelper.CreateFromArray(aggregatedList.ToArray());
    }
}
