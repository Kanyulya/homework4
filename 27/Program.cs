//напишите программу, которая принимает на вход число и выдает сумму цифр в числе

//    ТАНЦЫ С БУБНОМ((
    //это работает, но (как я думаю )здесь много лишнего
    //массивы сложны для моего понимания((

Console.WriteLine("введите число");
int str = Convert.ToInt32(Console.ReadLine());
string numb = Convert.ToString(str);
int[] Array = new int[numb.Length];
int N = Array.Length;
int sum = 0;
int i = 0;
for (i=0; i<N; i++){
    Array[i] = (int)char.GetNumericValue(numb[i]);
    sum = Array[i] + sum; 
    }
    Console.WriteLine(sum);  