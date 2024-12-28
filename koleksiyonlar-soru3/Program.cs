// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

string inp = Console.ReadLine().ToUpper();
char[] list = new char[5] { 'A', 'E', 'I', 'O', 'U' };
ArrayList res = new ArrayList();

foreach ( char c in inp)
{
    if (list.Contains(c) && !res.Contains(c) ) {  res.Add(c); }
}
foreach ( char c in res)
{
    Console.WriteLine(c);
}

res.Sort();

foreach (char c in res)
{
    Console.WriteLine(c);
}


//Console.ReadLine();

