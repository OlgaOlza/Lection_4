// Рекурсия 
// Факториал = 5! = 5*4*3*2*1 или 5! = 5*4!

//Функция факториал 
// Варианn 1

// int Factorial(int n)
// {
//     if (n == 1) return 1; // 1! = 1, 0! = 1
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 5; i++)
// {
// Console.WriteLine(Factorial(i));
// }

// Вариант 2 (с показателем факториала)

int Factorial(int n) // int или double = в зависимости от результата целое или десятичное число 
{
    if (n == 1) return 1; // 1! = 1, 0! = 1
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}




