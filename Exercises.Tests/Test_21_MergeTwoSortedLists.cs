using Exercises;
using StructuresLibrary;

namespace UnitTests;

public class ExerciseTests_21_MergeTwoLists
{
    public static IEnumerable<object?[]> MergeTwoLists()
    {
        // Case 1
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1, 2, 5 }),
            ListNodeHelper.CreateFromArray(new int[] { 1, 3, 5 }),
            ListNodeHelper.CreateFromArray(new int[] { 1, 1, 2, 3, 5, 5 })
        };
    }

    [Theory]
    [MemberData(nameof(MergeTwoLists))]
    public void MergeTwoLists_ShouldReturnExpectedOutput_WhenValidInputIsProvided(ListNode? list1, ListNode? list2, ListNode? expectedOutput)
    {
        // Act
        var output = Exercise.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(expectedOutput, output);
    }
}
