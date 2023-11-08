namespace LinearExpressions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a, b, c, d;

            Console.WriteLine("Введіть число a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число c:");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число d:");
            d = double.Parse(Console.ReadLine());

            double x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
            double y = ((5 * (a + b) * (c - d)) / ((1.0 / 2) * c)) + (d * d) * (((a * a) - (b * b)) / (b - a));
            double z = ((Math.Pow(((x * x) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
            double r = (((1.0 / 2) * a + (3.0 / 4) * b - (7.0 / 5)) / (3 * c + 1)) + (1.0 / (a - c));

            Console.WriteLine($"x = {x}, y = {y}, z = {z}, r = {r}");
        }
    }
}