// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// проверка максимального и минимального значений введеных цифр.
int[] ExaminationMinMax(int numM, int numN)
{
    if (numM == numN) 
    {
        int[] arr = new int[] {numM, numM, numM};
        return arr;
    }
    else if (numM > numN)
    {
        int[] arr = new int[] {numN, numM};
        return arr;
    }
    else
    {
        int[] arr = new int[] {numM, numN};
        return arr; 
    }
}

// поиск суммы
int SumNumbers (int min, int max)
{
    if (min > max) return 0;
    else return min += SumNumbers(min + 1, max);
}

Console.WriteLine("Введите натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());
int[] examinationMinMax = ExaminationMinMax(numberM, numberN);
if (examinationMinMax.Length > 2)
{
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {examinationMinMax[2]}");
}
else 
{
    int result = SumNumbers(examinationMinMax[0], examinationMinMax[1]);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");
}



