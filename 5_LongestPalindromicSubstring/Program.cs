// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//params 

string s = "babad";

//function 

//if (s.Length <= 1)
//    return true;
int len = s.Length;
int windowSize = len;

while (windowSize > 2)
{
    for(int i = 0; i + windowSize <= len; i++)
    {
        var substring = s.Substring(i, windowSize);
        if (IsPalindrome(substring))
            //return substring;
            break;
    }

    windowSize--;
}

//return s[0].ToString();


bool IsPalindrome(string s)
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