// Задача 3. Необязательная, дополнительная задача 
// 1. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// 2. В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами 
// 3. (если палиндромов нет, то среднее арифметическое считать равным 0). 
// 4. Полученные средние арифметические занести в одномерный массив.
// Например, задан массив:

// 100 404 504 225
// 550 478 800 363
// 505 101 410 479

// => [505, 252.5, 0, 363 ]

int[,] arr = new int[10, 10];
int sum = 0;
int divider = 0;

Random random = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        arr[i, j] = random.Next(100, 999);
        Console.Write("{0,5:D1}", arr[i, j]);
    }
    Console.WriteLine();
}

void rowWiseAvg(int[,] inputArray)
{
    int rows = inputArray.GetLength(0);
    int cols = inputArray.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        float rowAvg = 0;
        for (int x = 0; x < cols; x++)
        {                  
            rowAvg += inputArray[i,x];
        }
        rowAvg = rowAvg / cols;
        Console.Write("Average of row {0} is :{1}", i,rowAvg);         
    }
}


















// for (int j = 0, i = 0; j < 10; j++)
// {
//     int temp = Convert.ToInt32(arr[i, j]);
//     int b = 0;
//     while (temp != 0)
//     {
//         b = b * 10 + temp % 10; //Переворачиваем число по цифрам
//         temp /= 10; //Отбрасываем последнюю цифру
//     }
//     if (Convert.ToInt32(arr[i, j]) == b)
//         Console.WriteLine("Элемент массива [{0},{1}] Палиндром", i, j);
//     else
//         Console.WriteLine("Элемент массива [{0},{1}] Не палиндром", i, j);
//         sum += arr[i, j];
//         divider++;
// }

// int rsult = sum / divider;
// Console.WriteLine(rsult);
