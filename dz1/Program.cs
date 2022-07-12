/* Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее, а 
какое меньшее. */
void zadacha2(){
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 > number2)
    {
        Console.WriteLine("Первое число больше, чем второе число");
    }
    else if (number1 < number2)
    {
        Console.WriteLine("Певрое число меньше, чем второе число");
    }
    else
    {
        Console.WriteLine("Числа одинаковы");
    };
}

zadacha2();
