// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string x = "ooouiaaaaeiioooaeiou";
var result = GenerateParenthesis(x);
Console.WriteLine(result);

static int GenerateParenthesis(string myParam)
{
    char[] arr = new[] { 'a', 'e', 'i', 'o', 'u' };

    int currentVowelIndex = 0;
    int currentLength = 0;
    int maxLength = 0;

    var arrayChars = myParam.ToCharArray();

    foreach (char currentChar in arrayChars)
    {
        var currentVowel = arr[currentVowelIndex];
        if (currentChar == currentVowel)
        {
            currentLength++;
        }
        else
        {
            if (currentVowelIndex != 4 && currentChar == arr[currentVowelIndex + 1])
            {
                currentVowelIndex++;
                currentLength++;
            }
            else
            {
                if (currentVowelIndex == 4 && currentLength > maxLength)
                {
                    maxLength = currentLength;
                }

                currentVowelIndex = 0;
                currentLength = 1;
            }
        }
    }

    if (currentVowelIndex == 4 && currentLength > maxLength)
    {
        maxLength = currentLength;
    }

    return maxLength;
}