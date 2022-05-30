// Рекурсия Фибоначчи f(1) = 1, f(2) = 1, f(3) = 2, f(n) = f(n-1) + f(n-2) 

double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (double i = 1; i < 44; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)} ");
}

