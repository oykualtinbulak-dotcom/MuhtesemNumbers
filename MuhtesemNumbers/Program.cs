int i = 1;
int toplam = 0;
Console.Write("Sayı değeri giriniz: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x > i)
{
    while (x % i == 0)
    {
        toplam = toplam + i;
        i++;
    }
    i++;
}
if (x == toplam)
{
    Console.WriteLine("muk sayıdır");
}
else
{
    Console.WriteLine("muk sayı değildir");
}