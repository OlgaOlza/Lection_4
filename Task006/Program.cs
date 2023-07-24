//Последовательность Фибоначи
// 1 1 2 3 5 8 и т.д 
// Fibonacci = F
// F(1) = 1; F(2) = 1; 
//F(n) = F(n-1) + F(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}