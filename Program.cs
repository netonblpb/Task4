// Task 4: Найти максимальное из трех чисел

int[] numbers = new int[] {1, 6, 3};
int max = 0;

foreach (var x in numbers)
{
    if (x > max)
    max = x;    
}

Console.WriteLine(max);
