// Напишите программу , которая принимает на вход число (N)    3-> 1,8,27
// и выдает таблицу кубов чисел от 1 до N.                     5-> 1,8,27,64,125

Console.WriteLine("Введите число "); 
int Namber = Convert.ToInt32(Console.ReadLine()); 
 
void Cube (int N) 
{ 
    for (int i = 1; i <= N; i++) 
    { 
        int Namber2 = i * i * i; 
        Console.Write($"{Namber2},"); 
    } 
} 
Cube(Namber);
