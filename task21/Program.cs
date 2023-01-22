/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/




const int numberOfPoints = 2;
const int numberOfCoordinates = 3;

int[,] pointsCoordinates = new int[numberOfPoints,numberOfCoordinates];

Console.Clear();

for (int i = 0; i < numberOfPoints; i++)
{
    int[] inputValues;
    Console.Write($"Введите координаты точки {i+1} в формате \"X, Y, Z\" и нажмите клавишу ввода: ");

    while (!tryParseIntegerList(Console.ReadLine(), out inputValues))
    {
        Console.WriteLine("Ошибка ввода, попробуйте снова...");
        Console.Write($"Введите координаты точки {i+1} в формате \"X, Y, Z\" и нажмите клавишу ввода: ");
    }
        
    for (int j = 0; j < numberOfCoordinates; j++)
    {
        pointsCoordinates[i,j] = inputValues[j];
    }
}

for (int i = 0; i < numberOfPoints; i++)
{
    Console.Write($"Точка {i + 1} координаты X, Y, Z: ");
    for (int j = 0; j < numberOfCoordinates; j++)
    {
        Console.Write(pointsCoordinates[i,j]+", ");
    }
    Console.WriteLine();
}

double sum = 0;

for (int i = 0; i < numberOfCoordinates; i++)
{
    sum = sum + Math.Pow((pointsCoordinates[1,i] - pointsCoordinates[0, i]), 2);
}

Console.WriteLine ($"Расстояние между точками: {Math.Round(Math.Sqrt(sum), 2)}");







bool tryParseIntegerList(string input, out int[] inputValues)
{
    inputValues = default;
    string[] splits = input.Split(",");
    int[] result = new int[splits.Length];
    for (int i = 0; i < splits.Length; i++)
    {
        if (!int.TryParse(splits[i].Trim(), out result[i]) || splits.Length < numberOfCoordinates)
        {
            return false;
        }
    }
    inputValues = result;
    return true;
}