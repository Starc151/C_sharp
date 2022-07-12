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
    }
}

/* Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел. */

void zadacha4(){
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    int max = number1;

    if (max < number2)
    {
        max = number2;
    }
    if (max < number3)
    {
        max = number3;
    }
    Console.WriteLine("Максимальное число из введённых: " + max);
}

/* адача 6: Напишите программу, которая на вход 
принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка). */

void zadacha6(){
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number%2==0){
        Console.WriteLine("Число "+ number + " является чётным");
    }
    else
    {
        Console.WriteLine("Число "+ number + " является нечётным");
    }
}

// zadacha2();
// zadacha4();
zadacha6();
