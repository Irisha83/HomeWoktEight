// 1.  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// 3. Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
// 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray(int rows, int columns, int planes)
// {
//   int[,,] array3d = new int[rows, columns, planes];
//   int[] notRepeatArray = new int[rows * columns * planes];
//   if (rows * columns * planes < 100)
//     for (int x = 0; x < array3d.GetLength(0); x++)
//       for (int y = 0; y < array3d.GetLength(1); y++)
//         for (int z = 0; z < array3d.GetLength(2); z++)
//         {
//           int randomNum = 0;
//           for (int r = 0; r < notRepeatArray.Length; r++)
//           {
//             randomNum = new Random().Next(10, 100);
//             if (randomNum == notRepeatArray[r])
//               continue;
//             notRepeatArray[x + y + z] = randomNum;
//           }
//           array3d[x, y, z] = randomNum;
//         }
//   else
//     Console.WriteLine("Данный массив не может быть создан в рамках текущего задания поэтому заполнен нулями");
//   return array3d;
// }

// void Show3dArray(int[,,] array3d)
// {
//   for (int x = 0; x < array3d.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3d.GetLength(1); y++)
//       for (int z = 0; z < array3d.GetLength(2); z++)
//         Console.Write($"| {array3d[x, y, z]} ({x},{y},{z}) |");
//     Console.WriteLine("X");
//   }
// }

// int[,,] array3d = CreateRandom3dArray(3, 4, 3);
// Show3dArray(array3d);


// 5. Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] CreateSpiralArray(int size)
// {
//   int[,] array = new int[size, size];
//   int x = 0, y = 0;
//   int currentCount = 1;
//   while (size > 0)
//   {
//     for (int i = y; i <= y + size - 1; i++)
//       array[x, i] = currentCount++;
//     for (int j = x + 1; j <= x + size - 1; j++)
//       array[j, y + size - 1] = currentCount++;
//     for (int i = y + size - 2; i >= y; i--)
//       array[x + size - 1, i] = currentCount++;
//     for (int i = x + size - 2; i >= x + 1; i--)
//       array[i, y] = currentCount++;
//     x++;
//     y++;
//     size = size - 2;
//   }
//   return (array);
// }

// int[,] array = CreateSpiralArray(4);
// ShowSpiral(array);


// int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
// {
//   int[,] array = new int[rows, columns];
//   for (int i = 0; i < rows; i++)
//     for (int j = 0; j < columns; j++)
//       array[i, j] = new Random().Next(minVal, maxVal + 1);
//   return array;
// }

// void Show2dArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write(array[i, j] + " ");
//     Console.WriteLine();
//   }
// }

// void ShowSpiral(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       if (array[i, j] < 10)
//         Console.Write("0" + array[i, j] + " ");
//       else
//         Console.Write(array[i, j] + " ");
//     Console.WriteLine();
//   }
// }