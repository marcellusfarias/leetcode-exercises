using Exercises;
using StructuresLibrary;

namespace UnitTests;

public class ExerciseTests_25_ReverseNodesInKGroup
{
    public static IEnumerable<object?[]> Inputs()
    {
        // Case 1
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 }),
            2,
            ListNodeHelper.CreateFromArray(new int[] { 2,1,4,3,5 })
        };

        // Case 2
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 }),
            3,
            ListNodeHelper.CreateFromArray(new int[] { 3,2,1,4,5 })
        };

        // Case 3
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 }),
            1,
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 })
        };

        // Case 4
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 }),
            5,
            ListNodeHelper.CreateFromArray(new int[] { 5,4,3,2,1 })
        };

        // Case 4
        yield return new object?[]
        {
            ListNodeHelper.CreateFromArray(new int[] { 1,2,3,4,5 }),
            4,
            ListNodeHelper.CreateFromArray(new int[] { 4,3,2,1,5 })
        };
    }



    [Theory]
    [MemberData(nameof(Inputs))]
    public void ReverseKLists_ShouldReturnExpectedOutput_WhenValidInputIsProvided(ListNode input, int k, ListNode expectedOutput)
    {
        // Act
        var output = Exercise.ReverseKGroup(input, k);

        // Assert
        Assert.Equal(expectedOutput, output);
    }
}
