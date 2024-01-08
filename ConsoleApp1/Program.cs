// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// params

string s = "dvdf";

// function


var length = s.Length;
//if (length <= 1)
//    return length;

int maxLength = 0;

var array = s.ToCharArray();
List<char> currentWindow = new List<char>();

foreach (char value in array)
{
    if (!currentWindow.Contains(value))
    {
        currentWindow.Add(value);
    }
    else
    {
        if (currentWindow.Count > maxLength)
            maxLength = currentWindow.Count;

        var index = currentWindow.FindLastIndex(x => x == value);

        if (index == currentWindow.Count - 1)
        {
            currentWindow = new List<char>();
        }
        else
        {
            currentWindow = currentWindow.GetRange(index + 1, currentWindow.Count - index - 1); // does it free memory?
            currentWindow.TrimExcess();
        }

        currentWindow.Add(value);
    }
}


if (currentWindow.Count > maxLength)
    maxLength = currentWindow.Count;

Console.WriteLine($"length: {maxLength}");