/*Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/
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

/*Задача 13: Напишите программу, которая с помощью 
деления выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.*/
 void zadacha13(){
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number / 100 == 0){
        Console.WriteLine("Третьей цифры нет!");
        return;
    }
    else{
        for (int i = 10; number / i > 100;){
            number = number / i;
        }
        Console.WriteLine(number % 10);
    }
 }

// zadacha10();
zadacha13();
