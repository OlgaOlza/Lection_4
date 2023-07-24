﻿// Закрашивание выделенной области 

// определение двумерного масиисва 
int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
{0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
{0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
{0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
{0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};
void PrintImage(int[,] ; image)
{
    for (int i = 0; i < image.GetLength(0); i++) // кол-во строк 
    {
        for (int j = 0; j < image.GetLength(1); j++) // кол-во столбцов
        {
            Console.Write($"-{image[i, j]}-");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}
PrintImage(pic);
// метод который закрашивает картинку 
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
FillImage(4, 7);
PrintImage(pic);
