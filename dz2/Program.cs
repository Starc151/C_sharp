/*Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/
void zadacha10(){
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (99 > number || number > 999)
    {
        Console.WriteLine("Введённое число не подходит!");
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
    }
    else{
        for (int i = 10; number / i > 100;){
            number = number / i;
        }
        Console.WriteLine(number % 10);
    }
 }

 /*Задача 15: Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.*/
void zadacha15(){
    Console.Write("Введите номкр дня недели: ");
    int dayWeek = Convert.ToInt32(Console.ReadLine());
    if (dayWeek < 1 || dayWeek > 7){
        Console.Write("В неделе 7 дней, попробуйте снова: ");
    }
    switch (dayWeek)
    {
    case 1:
        Console.WriteLine("Понедельник, не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник, не выходной");
        break;
    case 3:
        Console.WriteLine("Среда, не выходной");
        break;
    case 4:
        Console.WriteLine("Четверг, не выходной");
        break;
    case 5:
        Console.WriteLine("Пятница, не выходной");
        break;
    case 6:
        Console.WriteLine("Суббота, выходной");
        break;
    case 7:
        Console.WriteLine("Воскресенье, выходной");
        break;
    }
    
}

// zadacha10();
// zadacha13();
// zadacha15();
