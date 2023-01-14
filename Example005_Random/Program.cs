// Работа с рандомными значениями
int numberA=new Random().Next(1,10); // 1,2,3,4,5,6,7,8,9
Console.WriteLine($"Первое число {numberA}");
int numberB=new Random().Next(1,10);
Console.WriteLine($"Второе число {numberB}");
Console.Write("Сумма двух чисел = ");
Console.WriteLine(numberA+numberB);


