Random random = new Random();
int RandomNumber = random.Next(100, 1000);
Console.WriteLine(RandomNumber);
int firstNumber = RandomNumber / 100;
int secondNumber = RandomNumber % 10;
Console.Write(firstNumber);
Console.Write(secondNumber);
