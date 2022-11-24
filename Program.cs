// Программа, которая на вход принимает 2 числа и выдает, какое из них большее, а какое меньшее
Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine($"Большее число A = {numberA}, меньшее число B = {numberB}");
}
else
{
    Console.WriteLine($"Большее число B = {numberB}, меньшее число A = {numberA}");
}