namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;

            Console.WriteLine(a + b);

            Console.WriteLine(a - b);

            Console.WriteLine(a * b);

            Console.WriteLine(a / b);

            Console.WriteLine(a % b);

            int quo = (a / b);
            int rem = (a % b);

            Console.WriteLine($"{a} / {b} is {quo} with a remainder of {rem}");

            Console.WriteLine($"AreaOfCircle");

            Console.WriteLine($"What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine();
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

        }
    }
}
