// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// params
string num = "III";

// algorithm
var list = new List<(string, int)>();
list.Add(("M", 1000));
list.Add(("D", 500));
list.Add(("C", 100));
list.Add(("L", 50));
list.Add(("X", 10));
list.Add(("V", 5));
list.Add(("I", 1));

int returningNumber = 0;

int i = 0;

while (i < list.Count)
{
    var item = list[i];

    i++;
}
