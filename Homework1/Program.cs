// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
// m = 3, n = 4.
// 0.5 7.96 -2.78 -0.2
// 1.7 -3.3 8.574 -9.9
// 8.5 7.87 -7.1 9.15

Console.Write("Введите значения m и n в строку через пробел и нажмите ввод ");
string[] num = Console.ReadLine().Split(' ');
int m = Convert.ToInt32(num[0]);
int n = Convert.ToInt32(num[1]);
Console.WriteLine($" Количество строк = {m}; Количество столбцов = {n}");

double[,] arr = new double[m,n];

Random random = new Random(100);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.NextDouble() * 10; // получаю случайное вещественное число в диапазоне от 0 до 1.
                                              // умножаю результат на 10 чтобы получить целую часть.
        Console.Write("{0,5:F1}", arr[i, j]); // Подсмотрел спецификатор стандартных числовых форматов:
                                              // https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN
                                              // спецификатор "F" или "f" c фиксированной запятой {0,5 - задаю расстояние между значениями
                                              // :F1- задаю количество цифр после запятой}
    }
    Console.WriteLine(); // Отделил строку
}
