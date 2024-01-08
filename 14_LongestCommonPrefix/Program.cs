// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

// param

string[] strs = new string[] { "flower", "flow", "flight" };

// code
StringBuilder sb = new StringBuilder();

char current = ' ';
int i = 0;
int max = Int32.MaxValue;
strs.ToList().ForEach(x => { if (x.Length < max) max = x.Length; });


while(i < max)
{
    current = strs[0][i];

    foreach (var str in strs)
    {
        if (str[i] != current)
            break;
    }

    sb.Append(current);

    i++;
}

