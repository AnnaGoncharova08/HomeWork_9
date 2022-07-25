// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Zadacha66()
{
int numberM = 1;
int numberN = 15;
Recursion(numberM, numberN);
Console.WriteLine();

void Recursion(int numberM, int numberN, int result = 0)
{
    if (numberM > numberN) 
    {
        Console.WriteLine(result);
        return;
    }
    result += numberM;
    numberM++;
    Recursion(numberM, numberN, result);
    
}
}
Zadacha66();