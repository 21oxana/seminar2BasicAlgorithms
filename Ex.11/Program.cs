/* Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру 
этого числа. */

/* void Zadacha11() 
{
    Random rand = new Random();
    int number = GenerateNumber(100, 999);
    Console.WriteLine("Случайное число: " + number);
    Console.WriteLine("Наибол: "+ (number / 100 * 10 + number % 10));
}

int GenerateNumber(int minValue, int maxValue)
{
    return new Random().Next(minValue, ++maxValue);
}
  int MaxDigit(int number)
  {
    int tens = number /10;
    int ones = number % 10;
    if (tens > ones)
    {
        Console.WriteLine(tens);
    }
    else
    {
        Console.WriteLine(ones); 
    }
  }  
Zadacha11(); */
    
