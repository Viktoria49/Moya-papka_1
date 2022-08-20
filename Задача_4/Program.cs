// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine());
Console.Write("Введите третее число: ");
int numberC = int.Parse (Console.ReadLine());

if (numberA == numberB && numberB == numberC)
{
    Console.Write("числа равны");
}
else{
if (numberA < numberB && numberB > numberC)
{
    Console.Write($"число {numberB} максимальное");
}
else
if (numberB < numberC && numberA < numberC)
{
    Console.Write($"число {numberC} максимальное");
}
else
if (numberA > numberC && numberA > numberB);
{
    Console.Write($"число {numberA} максимальное");
}
}