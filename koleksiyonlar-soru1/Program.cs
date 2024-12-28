// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
int n = 0;
try
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0)
    {
        throw new Exception("Lütfen pozitif bir sayı giriniz");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


ArrayList primeList = new ArrayList();
ArrayList list = new ArrayList();

for (int i = 0; i < n; i++)
{
    try
    {
        int j = Convert.ToInt32(Console.ReadLine());
        if (j <= 0) { throw new Exception("Lütfen pozitif sayı giriniz!"); }

        if (isPrime(j)) { primeList.Add(j); }
        else
        {
            list.Add(j);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

bool isPrime(int x)
{
    if (x == 0 || x == 1)
    {
        return false;
    }
    else if (x == 2)
    { return true; }

    else
    {
        int y = 0;
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                y++;
            }
        }
        if (y == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

primeList.Sort();
primeList.Reverse();
Console.WriteLine("Primelist :");
foreach (int x in primeList) { Console.WriteLine(x); }
list.Sort();
list.Reverse();
Console.WriteLine("List :");
foreach (int z in list) { Console.WriteLine(z); }

int primeSum = 0;
foreach (int x in primeList) { primeSum += x; }
Console.WriteLine("Primelist Eleman sayısı: " + primeList.Count + " Ortalaması: " + primeSum / primeList.Count);

int listSum = 0;
foreach (int x in list) { listSum += x; }
Console.WriteLine("Liste Eleman sayısı: " + list.Count + " Ortalaması: " + listSum / list.Count);




// Console.ReadLine();