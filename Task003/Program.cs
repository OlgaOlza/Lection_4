// Метод который печатает двумерную матрицу 
// и заполняет произвольными числами 



// создание двумерной матрицы
int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // кол-во строк 
    {
        for (int j = 0; j < matr.GetLength(1); j++) // кол-во столбцов
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Заполняет матрицу случайными числами 
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // кол-во столбцов
        {
            matr[i,j] = new Random().Next(1,10); //
        }
    }
}

// выводит матрицу на печать 
// PrintArray(matrix); - показывает размер матрицы с "0"
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // разделяет матрицу с "0" ис произвольными числами строкой 
PrintArray(matrix);
