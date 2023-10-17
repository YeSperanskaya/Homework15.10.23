// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




int result = SumNumbers()


int SumNumbers (int numM, int numN)
{
    int sum = 0;
    if(numM == numN) return numM+sum;
    sum = sum + SumNumbers(numM + 1, numN);
    return sum;
}   



// int ExaminationMinMax (int numM, int numN)
// {
//     int sum = 0;
//     sum = sum + 
//     if 
//     if (numM == numN) return numM;
//     else if(numM > numN)
//     {

//     }
// }
// int SumNumbers (int numM, int numN)
// {
//     int sum = 0;
//     if (numM == numN) return numM;
//     else if (numM > numN) 
//     {
//         if (numM == numN) return 0;
//         sum = sum + SumNumbers(numM - 1);
//         return sum;
//     }
//     else
//     {
//         if (numM == numN) return 0;
//         sum = sum + SumNumbers(numN - 1);
//         return sum;
//     }

// }   
Console.WriteLine("Введите натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {sumNumbers}");


