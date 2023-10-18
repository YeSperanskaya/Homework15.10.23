// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return AkkermanFunction(numM - 1, 1);
    else return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
}

Console.WriteLine("Введите первое натуральное число (от 0 до 3)");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число (от 0 до 3)");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM >= 0 && numberM < 4 && numberN >= 0 && numberN < 4)
{
    int resultAkkerman = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {resultAkkerman}");
}
else
{
    System.Console.WriteLine("Во избежание негативных последствий для вашего персонального компьютера, рекомендуется ввести натуральные числа в диапазоне от 0 до 3!");
}



