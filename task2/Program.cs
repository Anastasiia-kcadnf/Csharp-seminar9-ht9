// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfElements(int first, int last)
{
    if(first == last)
    {
        return first;
    }

    return first + SumOfElements(first+1, last);
}

int numM = ReadInt("Enter 1st number (M)");
int numN = ReadInt("Enter 2nd number (N)");
System.Console.WriteLine($"The sum of natural numbers from {numM} to {numN} is {SumOfElements(numM,numN)}.");