// Вычислить A в степени "n"
int PowerFor(int A, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= A;
    return result;
}

int PowerRec(int A, int n)
{
    //return n==0 ? : PowerRec(A, n-1) *A; тернарный оператор
    if (n == 0) return 1;
    else return PowerRec(A, n - 1) * A;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024