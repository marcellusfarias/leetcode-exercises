using Exercises;
using StructuresLibrary;

namespace UnitTests;

public partial class ExerciseTests
{
    public static IEnumerable<object?[]> MergeKSortedLists()
    {
        // Case 1
        var input = new ListNode?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1, 4, 5 }),
            ListNodeHelper.CreateFromArray(new int[] { 1, 3, 4 }),
            ListNodeHelper.CreateFromArray(new int[] { 2, 6 })
        };

        yield return new object?[]
        {
            input,
            ListNodeHelper.CreateFromArray(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 })
        };

        // Case 2
        input = new ListNode?[] { ListNodeHelper.CreateFromArray(new int[] { }) };
        yield return new object?[] { input, null };

        // Case 3
        input = new ListNode?[] 
        { 
            ListNodeHelper.CreateFromArray(new int[] { }),
            ListNodeHelper.CreateFromArray(new int[] { 1 }) 
        };

        yield return new object?[] { input, ListNodeHelper.CreateFromArray(new int[] { 1 }) };
    }


    [Theory]
    [MemberData(nameof(MergeKSortedLists))]
    public void MergeKLists_ShouldReturnExpectedOutput_WhenValidInputIsProvided(ListNode[]? input, ListNode? expectedOutput)
    {
        // Act
        var output = Exercise.MergeKLists(input);

        // Assert
        Assert.Equal(expectedOutput, output);
    }
}
