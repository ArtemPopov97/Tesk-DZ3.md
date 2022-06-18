// Напишите программу,которая принимает на               14212 - > no
// вход пятизнаное число и проверяет ,является ли оно    23432 - > yes
// палиндромом.                                          12821 - > yes

System.Console.Write("Введите число : ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = NumberA % 10;
int NumberС = NumberA / 10 % 10;
int NumberD = NumberA / 100 % 10;
int NumberE = NumberA / 1000 % 10;
int NumberF = NumberA / 10000;
int result = (NumberB*10000)+(NumberС*1000)+(NumberD*100)+(NumberE*10) + NumberF;
// Console.WriteLine($"NumberA % 10 (B) {NumberB}");
// Console.WriteLine($"NumberA / 10 % 10 (С) {NumberС}");
// Console.WriteLine($"NumberA / 100 % 10 (D) {NumberD}");
// Console.WriteLine($"NumberA / 1000 % 10 (E) {NumberE}");
// Console.WriteLine($"NumberA / 10000 (F) {NumberF}");
// Console.WriteLine($"результат Res {result}");
if (result > NumberA || result < NumberA)
{
    Console.WriteLine("не палиндромом"); 
}
else
{
    Console.WriteLine("Да палиндромом");
}