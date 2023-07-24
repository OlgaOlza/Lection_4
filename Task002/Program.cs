// Пример двумерного массива с числами 

// Вариант 1
// int[,] matrix = new int[3, 4];


// for (int i = 0; i < 3; i++) // кол-во строк 
// {
//     for (int j = 0; j < 4; j++) // кол-во столбцов
//     {
//         Console.Write($"-{matrix[i, j]}-");
//     }
// Console.WriteLine();
// }

// Вариант 2

int[,] matrix = new int[3, 4];


for (int i = 0; i < matrix.GetLength(0); i++) // кол-во строк 
{
    for (int j = 0; j < matrix.GetLength(1); j++) // кол-во столбцов
    {
        Console.Write($"-{matrix[i, j]}-");
    }
Console.WriteLine();
}

