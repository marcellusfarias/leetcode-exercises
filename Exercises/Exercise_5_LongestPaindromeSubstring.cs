namespace Exercises;

public partial class Exercise
{
    // TODO: create tests
    public static string GetLongestPalindrome(string s)
    {
        if (s.Length <= 1)
            return string.Empty;

        int len = s.Length;
        int windowSize = len;

        while (windowSize > 2)
        {
            for (int i = 0; i + windowSize <= len; i++)
            {
                var substring = s.Substring(i, windowSize);
                if (IsPalindrome(substring))
                    return substring;
            }

            windowSize--;
        }

        return s[0].ToString();
    }

    static bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        bool isPalindrome = true;

        while (i < j)
        {
            if (s[i] != s[j])
            {
                isPalindrome = false;
                break;
            }

            i++;
            j--;
        }

        return isPalindrome;
    }
}
