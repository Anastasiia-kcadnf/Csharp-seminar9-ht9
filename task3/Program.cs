// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunct(int numberM, int numberN)
{
    if(numberM == 0)
        return numberN + 1;
    else if(numberN == 0)
        return AkkermanFunct(numberM - 1, 1);
    else 
        return AkkermanFunct(numberM - 1, AkkermanFunct(numberM, numberN - 1)); 
}

int numM = ReadInt("Enter 1st parameter (nonnegative number m)");
int numN = ReadInt("Enter 2nd parameter (nonnegative number n)");
Console.WriteLine($"Akkerman function A({numM},{numN}) = {AkkermanFunct(numM, numN)}");