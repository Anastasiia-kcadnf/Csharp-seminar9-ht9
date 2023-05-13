// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные 
// числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void AllEvenNaturalsMtoN(int first, int last)
{
    if (first > last)
    {
        return;
    }

    if (first % 2 == 0)
    {
        System.Console.Write($"{first} ");
    }
    
    AllEvenNaturalsMtoN(first+1, last);      
}

int numM = ReadInt("Enter 1st number (M)");
int numN = ReadInt("Enter 2nd number (N)");
AllEvenNaturalsMtoN(numM, numN);
