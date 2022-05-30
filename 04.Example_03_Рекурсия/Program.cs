double Factorial(double n)
{
    // 1! = 1 , 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (double i = 1; i<40;i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)} "); 
}
