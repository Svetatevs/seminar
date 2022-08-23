// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = firstNumber / secondNumber;
if(result == secondNumber) 
{
Console.Write("Кратно");
}
else
{
    double ostatok = firstNumber % secondNumber;
    Console.Write($"Остаток: {ostatok}");
}