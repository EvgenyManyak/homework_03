double x, y, z, x1, y1, z1, l;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
z = Convert.ToInt32(Console.ReadLine());
x1 = Convert.ToInt32(Console.ReadLine());
y1 = Convert.ToInt32(Console.ReadLine());
z1 = Convert.ToInt32(Console.ReadLine());
l = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1) + (z - z1) * (z - z1));
{
    Console.WriteLine(l);
}
