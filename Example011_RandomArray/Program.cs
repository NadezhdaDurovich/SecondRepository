﻿// Массив из 10 чисел,заполняемый рандомно.
void FillArray(int[]collection)
{
    int length=collection.Length;
    int index=0;
    While (index<length)
    {
        collection[index]=new Random().Next(1,10);
        // index=index+1;
        index++;
    }
}
void PrintArray(int[]coll)
{
    int count=coll.Length;
    int position=0;
    while (position<count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
int[]array=new int[10];
FillArray(array);
PrintArray(array);