namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double m, n;
            double a, b, x;

            Console.WriteLine("Введіть число m:");
            m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число n:");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число x:");
            x = double.Parse(Console.ReadLine());

            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"z1 = {z1:F3}, z2 = {z2:F3}, y = {y:F3}");
        }
    }
}