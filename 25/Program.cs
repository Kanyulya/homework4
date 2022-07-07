// напишите программу, которая принимает на вход два числа (А и В) и возводит число А в натуральную степень В
Console.WriteLine("Введите число А");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
double numB = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(numA, numB);       //здесь программа ругалась, если вместо "double" везде были "int"
Console.WriteLine("число " + numA + " в степени " + numB + " равно " + result);