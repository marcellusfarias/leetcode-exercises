using StructuresLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises;

public partial class Exercise
{

    public static ListNode? ReverseKGroup(ListNode head, int k)
    {
        if (head is null)
        {
            return null;
        }

        var node = head;

        while (node is not null)
        {
            var stack = GetNextKValues(node, k);

            if (stack is null)
            {
                return head;
            }

            while (stack.TryPop(out int value))
            {
                node!.val = value;
                node = node.next;
            }
        }

        return head;
    }

    private static Stack<int>? GetNextKValues(ListNode head, int k)
    {
        Stack<int> values = new Stack<int>();
        var node = head;
        for (int i = 0; i < k; i++)
        {
            if (node is null)
            {
                return null;
            }
            else
            {
                values.Push(node.val);
                node = node.next;
            }
        }

        return values;
    }

}
