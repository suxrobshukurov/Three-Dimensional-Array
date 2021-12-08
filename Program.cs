int[,,] ThreeDimensionalArray = new int[4, 3, 5];

Random rand = new Random();

for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
{
    for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
    {
        for (int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
        {
            ThreeDimensionalArray[i, j, k] = rand.Next(100);
        }
    }
}



for (int i = 0; i < ThreeDimensionalArray.GetLength(0); i++)
{
    Console.WriteLine($"Page №: {i + 1} \n");
    for (int j = 0; j < ThreeDimensionalArray.GetLength(1); j++)
    {
        for(int k = 0; k < ThreeDimensionalArray.GetLength(2); k++)
        {
            Console.Write($"{ThreeDimensionalArray[i, j, k]} \t");
        }
        Console.WriteLine("\n");

    }
    Console.WriteLine("\n");
}
Console.WriteLine();

Console.WriteLine("Зубчатый трехмерный массив \n"); 
/* 
 * Инициализация зубчатого трехмерного массива и выделение памяти для массива 1 уровня
 * размер которого генерируется от 3 до 6 массивов
 */
int[][][] jaggedArray = new int[rand.Next(3, 6)][][];

for (int i = 0; i < jaggedArray.Length; i++) // перебор массива 1 уровня
{
    /* 
    * Инициализация массива 2 уровня и выделение памяти для массива 2 уровня
    * размер которого генерируется от 2 до 6 массивов
    */
    jaggedArray[i] = new int[rand.Next(2, 6)][]; 

    for (int j = 0; j < jaggedArray[i].Length; j++) // перебор массива 2 уровня
    {
        /* 
        * Инициализация массива 3 уровня и выделение памяти для массива 3 уровня
        * размер которого генерируется от 2 до 6 массивов
        */
        jaggedArray[i][j] = new int[rand.Next(2, 6)];

        for (int k = 0; k < jaggedArray[i][j].Length; k++)
        {
            // заполняем массив 3 уровня рандомными числами в диапазоне до 100
            jaggedArray[i][j][k] = rand.Next(100);

        }
    }
}

//вывыод зубчатого трехмерного массива в виде таблицы 
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine($"Page №: {i + 1}");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        for (int k = 0; k < jaggedArray[i][j].Length; k++)
        {
            Console.Write($"{jaggedArray[i][j][k]} \t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");
}


Console.ReadLine(); 