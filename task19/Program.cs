/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

int findDigitInPosition(int number, int position){
    if (position < 0 
    || Convert.ToInt32((number / Math.Pow(10, position))) == 0 )
    { 
        return -1; //position is out of limits
    }        
    return Convert.ToInt32( number % Math.Pow(10, position + 1) / Math.Pow(10, position) );
}


const int inputValueLenth = 5;
int number;

Console.Clear();
Console.Write($"Введите {inputValueLenth} значное число: ");
string inputString = Console.ReadLine();

if (inputString.Length != inputValueLenth)
{
    Console.WriteLine("Ошибка ввода - необходимо ввести пятизначное число");
}
else
{
    try
    {
        number = Convert.ToInt32(inputString);
        string strNot = "";
        
        for (int i = 0; i < inputValueLenth / 2; i++)
        {
            int rightNumber = findDigitInPosition(number, inputValueLenth - i - 1);
            int leftNumber  = findDigitInPosition(number, i);
            //Console.WriteLine($"step: {i} \t left: {leftNumber}, right: {rightNumber}");

            if (rightNumber != leftNumber)
            {
                strNot = " не";
                break;
            }
        }
        Console.WriteLine($"Введенное число{strNot} является полиндромом");
    }
    catch
    {
        Console.WriteLine("Ошибка ввода - введите число");
    }    
}


