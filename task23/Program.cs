/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/


Console.Clear();
Console.Write($"Введите целое число: ");
string inputString = Console.ReadLine();
int maxNumber;
int gapBetweenColumns = 2;

if (int.TryParse(inputString, out maxNumber)){    
    
    int maxNumberLength   = Convert.ToString(maxNumber).Length;
    int maxCalculatedValueLength = Convert.ToString(Math.Pow(maxNumber,3)).Length;

    int maxColumnWidth =         
        maxNumberLength + 
        maxCalculatedValueLength +
        gapBetweenColumns*2 + 2;
            
    int currentNumber = 1;

    while (currentNumber <= maxNumber)
    {   
        if ( Console.WindowWidth - Console.CursorLeft < maxColumnWidth)
        {
            Console.WriteLine();
        }

        Console.Write("|");
     
        Console.Write((currentNumber + "").PadLeft(maxNumberLength + gapBetweenColumns,' '));
        Console.Write("³=");
        Console.Write((Math.Pow(currentNumber, 3) + "").PadRight(maxCalculatedValueLength + gapBetweenColumns,' '));
        
        currentNumber++;
    }
    Console.WriteLine();

}
else
{
    Console.WriteLine("Ошибка ввода, введите целое число");
}