using System.Diagnostics;

TestFactorial();
TestDegree();
TestFastDergree();
Console.WriteLine(CalculateFactorial(6));
Console.WriteLine(CalculateFactorial(1));
Console.WriteLine(CalculateFactorial(0));
Console.WriteLine(CalculatePower(2, -4));
Console.WriteLine(CalculatePower(2, 4));
Console.WriteLine(FastPower(-2, 3));
Console.WriteLine(FastPower(3, 11));

static long CalculateFactorial(int factorial)
{
    if (factorial < 0)
        return 0;
    if (factorial == 0)
        return 1;
    return factorial * CalculateFactorial(factorial - 1);
}

static void TestFactorial()
{
    Debug.Assert(CalculateFactorial(0) == 1);
    Debug.Assert(CalculateFactorial(1) == 1);
    Debug.Assert(CalculateFactorial(-1) == 0);
    Debug.Assert(CalculateFactorial(3) == 6);

}

static double CalculatePower(double x, int n)
{
    if (n == 0)
        return 1;
    if (n > 0)
        return x * CalculatePower(x, n - 1);
    return 1 / CalculatePower(x, -n);
}

static void TestDegree()
{
    Debug.Assert(CalculatePower(2, 0) == 1);
    Debug.Assert(CalculatePower(2, 3) == 8);
    Debug.Assert(CalculatePower(2, -3) == 0.125);
}

static double FastPower(double x, int n)
{
    if (n < 0)
        return -1;
    if (n == 0)
        return 1;
    if (n == 1)
        return x;
    if (n % 2 == 0)
    {
        double square = FastPower(x, n / 2);
        return square * square;
    }
    return x * FastPower(x, n - 1);
}

static void TestFastDergree()
{
    Debug.Assert(FastPower(1, 0) == 1);
    Debug.Assert(FastPower(-1, 3) == -1);
}