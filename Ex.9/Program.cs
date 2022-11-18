/* Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа. */

void Zadacha1() // это метод и в нем будет решаться данная задача
{
    Random rand = new Random();
    int number = rand.Next(10, 100); //генератор случайных чисел

    Console.WriteLine("Случайное число: " + number);
    int tens = number / 10; //целочисленное деление
    int ones = number % 10; //остаток от деления

    Console.Write("Наибольшая цифра числа: ");

    if (tens > ones)
    {
        Console.WriteLine(tens);
    }
    else
    {
        Console.WriteLine(ones); 
    }
}
Zadacha1();


