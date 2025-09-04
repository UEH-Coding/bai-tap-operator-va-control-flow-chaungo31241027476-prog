using System;

class Program
{
    static void Main()
    {
        // = SLIDE 9 =
        Console.WriteLine(" Bài 1 (Slide 9): Calculator ");
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+,-,*,/): ");
        char op = Console.ReadLine()![0];
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': result = b != 0 ? a / b : double.NaN; break;
            default: Console.WriteLine("Invalid operator"); break;
        }
        Console.WriteLine("Result = " + result);

        Console.WriteLine("\n Bài 2 (Slide 9): Function x = y^2 + 2y + 1 ");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine("y = {0}, x = {1}", y, x);
        }

        Console.WriteLine("\n Bài 3 (Slide 9): Speed ");
        Console.Write("Enter distance (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Hours: "); int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Minutes: "); int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Seconds: "); int s = Convert.ToInt32(Console.ReadLine());
        double timeHours = h + m / 60.0 + s / 3600.0;
        double speedKmh = distance / timeHours;
        double speedMph = speedKmh / 1.609;
        Console.WriteLine("Speed = {0} km/h = {1} miles/h", speedKmh, speedMph);

        Console.WriteLine("\n Bài 4 (Slide 9): Sphere ");
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = 4.0 / 3 * Math.PI * r * r * r;
        Console.WriteLine("Surface = {0}, Volume = {1}", surface, volume);

        Console.WriteLine("\n Bài 5 (Slide 9): Character check ");
        Console.Write("Enter a character: ");
        char c = Console.ReadLine()![0];
        if ("aeiouAEIOU".Contains(c)) Console.WriteLine("It is a vowel.");
        else if (char.IsDigit(c)) Console.WriteLine("It is a digit.");
        else Console.WriteLine("Other symbol.");

        // = SLIDE 21 =
        Console.WriteLine("\n Bài 1 (Slide 21): Even or Odd ");
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");

        Console.WriteLine("\n Bài 2 (Slide 21): Largest of three ");
        Console.Write("Enter three numbers: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(n1, Math.Max(n2, n3));
        Console.WriteLine("Largest = " + max);

        Console.WriteLine("\n Bài 3 (Slide 21): Quadrant ");
        Console.Write("Enter x: "); int xC = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: "); int yC = Convert.ToInt32(Console.ReadLine());
        if (xC > 0 && yC > 0) Console.WriteLine("Quadrant I");
        else if (xC < 0 && yC > 0) Console.WriteLine("Quadrant II");
        else if (xC < 0 && yC < 0) Console.WriteLine("Quadrant III");
        else if (xC > 0 && yC < 0) Console.WriteLine("Quadrant IV");
        else Console.WriteLine("On axis");

        // = SLIDE 22 =
        Console.WriteLine("\n Bài 1 (Slide 22): Triangle type ");
        Console.Write("Enter 3 sides: ");
        int s1 = Convert.ToInt32(Console.ReadLine());
        int s2 = Convert.ToInt32(Console.ReadLine());
        int s3 = Convert.ToInt32(Console.ReadLine());
        if (s1 == s2 && s2 == s3) Console.WriteLine("Equilateral");
        else if (s1 == s2 || s2 == s3 || s1 == s3) Console.WriteLine("Isosceles");
        else Console.WriteLine("Scalene");

        Console.WriteLine("\n Bài 2 (Slide 22): Average and Sum ");
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Sum = " + sum + ", Average = " + (sum / 10.0));

        Console.WriteLine("\n Bài 3 (Slide 22): Multiplication table ");
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++) Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

        Console.WriteLine("\n Bài 4 (Slide 22): Number triangle ");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write(j + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\n Bài 6 (Slide 22): Harmonic series ");
        Console.Write("Enter n: ");
        int nH = Convert.ToInt32(Console.ReadLine());
        double sumH = 0;
        for (int i = 1; i <= nH; i++)
        {
            sumH += 1.0 / i;
            Console.Write("1/{0} ", i);
        }
        Console.WriteLine("\nSum = " + sumH);

        Console.WriteLine("\n Bài 7 (Slide 22): Perfect numbers ");
        Console.Write("Enter range limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= limit; i++)
        {
            int divSum = 0;
            for (int j = 1; j < i; j++) if (i % j == 0) divSum += j;
            if (divSum == i) Console.WriteLine(i + " is a Perfect number");
        }
Console.WriteLine("\n Bài 8 (Slide 22): Prime check ");
        Console.Write("Enter number: ");
        int primeNum = Convert.ToInt32(Console.ReadLine());
        bool isPrime = primeNum > 1;
        for (int i = 2; i <= Math.Sqrt(primeNum); i++)
            if (primeNum % i == 0) { isPrime = false; break; }
        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
