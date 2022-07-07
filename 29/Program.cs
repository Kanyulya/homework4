// напишите программу, которая задает массив из 8 элементов и выводит их на экран

int[] mass(int n) 
{
    int[] result = new int[n];
    for(int i=0; i<n; i++)
    {
        int num =  (new Random().Next(0, 99)); 
        result[i] = num;
        Console.Write(result[i] + " ");
            }
    return result;
}
Console.WriteLine("введите число элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
mass(n);
Console.WriteLine();
