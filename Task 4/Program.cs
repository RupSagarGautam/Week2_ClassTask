// See https://aka.ms/new-console-template for more information

int[] ary = {1,2,3,4,5};

Array.Sort(ary);
Console.WriteLine("Sorted array are:" + ary);

Array.Reverse(ary);
Console.WriteLine("Reversed array are:" + ary);

for (int i = 0; i < ary.Length; i++)
{
    Console.WriteLine(ary[i]);
}

int index = Array.IndexOf(ary, 3);
Console.WriteLine("Index of 3 is: "+index);