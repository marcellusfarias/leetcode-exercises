// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// params

var numns1 = new int[] { 1, 3 };
var numns2 = new int[] { 2, 4  };

// function
var mergedArray = numns1.Concat(numns2).OrderBy(x => x).ToArray();
int len = mergedArray.Length;
double value = 0;

if (len % 2 != 0)
    value = mergedArray[(int)Math.Ceiling(Convert.ToDouble(len / 2))];
else
    value = (mergedArray[(len / 2) - 1] + mergedArray[(len / 2)])/2.0;


Console.WriteLine(value);

