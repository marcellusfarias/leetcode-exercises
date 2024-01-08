// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

// params
int num = 100;

// algo

var list = new List<string>();
list.Add("M");
list.Add("D");
list.Add("C");
list.Add("L");
list.Add("X");
list.Add("V");
list.Add("I");

var sb = new StringBuilder();

int thousands = num / 1000;
if (thousands > 0)
{
    for (int i = 0; i < thousands; i++)
        sb.Append("M");

    num = num % 1000;
}

int divider = 100;
int j = 0;
while (divider > 0)
{
    var firstDigit = list[j]; // M
    var secondDigit = list[j + 1]; // D
    var third = list[j + 2]; // C

    int result = num / divider;

    switch (result)
    {
        case 0:
            break;
        case <= 3:
            for (int i = 0; i < result; i++)
                sb.Append(third);
            break;
        case 4:
            sb.Append(third).Append(secondDigit);
            break;
        case <= 8:
            sb.Append(secondDigit);
            var temp = result - 5;
            for (int i = 0; i < temp; i++)
                sb.Append(third);
            break;
        case 9:
            sb.Append(third).Append(firstDigit);
            break;
    }

    num = num % divider;
    divider = divider / 10;
    j = j + 2;
}

Console.WriteLine(sb.ToString());