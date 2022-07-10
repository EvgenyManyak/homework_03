int n = Convert.ToInt32(Console.ReadLine());
int n1, n2, n4, n5;
n1 = n / 10000;
n2 = (n % 10000) / 1000;
n4 = (n % 100) / 10;
n5 = n % 10;
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("данное число является палиндромом");
}
else
{
    Console.WriteLine("данное число не является палиндромом");
}