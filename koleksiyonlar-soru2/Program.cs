// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları
//ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

Console.WriteLine("Sayı adedini giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    int s = Convert.ToInt32(Console.ReadLine());
    list.Add(s);
}

foreach (int i in list) { Console.WriteLine(i); }


list.Sort();

int[] mins = new int[3];

for (int i = 0; i < 3; i++)
{
    mins[i] = list[i];
}

int[] maxs = new int[3] { list[list.Count-3], list[list.Count-2], list[list.Count-1] };

foreach (int i in mins) {  Console.WriteLine(i); }

foreach (int i in maxs) { Console.WriteLine(i); }

int minsTop = 0;
int maxsTop = 0;

for (int i = 0;i < 3; i++)
{
    minsTop += mins[i];
    maxsTop += maxs[i];
}

Console.WriteLine("Max ortalama: " + maxsTop / 3);
Console.WriteLine("Min ortalama: " + minsTop / 3);
Console.WriteLine("Toplam ortalama: " + (minsTop + maxsTop)/3);


//Console.ReadLine();




