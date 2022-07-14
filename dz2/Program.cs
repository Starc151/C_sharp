/*Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.
*/
void zadacha10(){
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (99 > number || number > 999)
    {
        Console.WriteLine("Введённое число не подходит!");
        return;
    }
    number = number / 10 % 10;
    Console.WriteLine(number);
 }

zadacha10();
