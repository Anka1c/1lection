int NumberA = new Random().Next(1, 99); //new Random().Next(min, max) где max=max-1
Console.WriteLine(NumberA); //чтобы видеть какое рандомное число выбрано
int NumberB = new Random().Next(1, 99); //диапазон будет от 1 до 98
Console.WriteLine(NumberB);
Console.Write(NumberA + NumberB);