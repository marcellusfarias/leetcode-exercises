// See https://aka.ms/new-console-template for more information
// params
string s = "]";

// code
var isValid = IsValid(s);
if(isValid)
    Console.WriteLine($"String {s} is valid");
else
    Console.WriteLine($"String {s} is not valid");

static bool IsValid(string s)
{
    var parenthesis = new Dictionary<char, char>();
    parenthesis.Add(')', '(');
    parenthesis.Add(']', '[');
    parenthesis.Add('}', '{');

    var stack = new Stack<char>();

    foreach (char c in s)
    {
        if (parenthesis.TryGetValue(c, out char openingParenthesis))
        {
            if (!stack.TryPop(out char lastOpeningParenthesis) || lastOpeningParenthesis != openingParenthesis)
                return false;
        }
        else
        {
            stack.Push(c);
        }
    }

    return !stack.Any();
}
