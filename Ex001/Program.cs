// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Zadacha64()
{
int numberM = 1;
int numberN = 20;
Recursion(numberM, numberN);
Console.WriteLine();

void Recursion(int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberM%3 == 0)
    {
        Console.Write(numberM + " ");
    }
    numberM++;
    Recursion(numberM, numberN);
}
}
Zadacha64();