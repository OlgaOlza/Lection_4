// Пример двумерного массива 


string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++) // кол-во строк 
{
    for (int colums = 0; colums < 5; colums++) // кол-во столбцов
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
