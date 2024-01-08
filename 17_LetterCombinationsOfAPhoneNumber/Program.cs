// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//params

string digits = "";

//code
if(string.IsNullOrEmpty(digits))
    return Array.Empty<string>();

var values = new Dictionary<string, string>();
values.Add("2", "abc");
values.Add("3", "def");
values.Add("4", "ghi");
values.Add("5", "jkl");
values.Add("6", "mno");
values.Add("7", "pqrs");
values.Add("8", "tuv");
values.Add("9", "wxyz");

var splittedDigits = digits.ToCharArray();
LinkedList<string> splittedAlpha = new LinkedList<string>();
for (int i = 0; i < splittedDigits.Count(); i++)
{
    splittedAlpha.AddLast(values.GetValueOrDefault(splittedDigits[i].ToString())!);
}


List<string> combinations = new List<string>();
DoCombinations(string.Empty, splittedAlpha.First!, combinations);

foreach (var item in combinations)
{
    Console.WriteLine(item);
}

void DoCombinations(string current, LinkedListNode<string> splittedAlpha, List<string> combinations)
{
    var values = splittedAlpha.Value;

    foreach (var value in values)
    {
        string currentString = string.Concat(current, value);
        if(splittedAlpha.Next == null)
            combinations.Add(currentString);
        else
            DoCombinations(currentString, splittedAlpha.Next, combinations);
    }
}
