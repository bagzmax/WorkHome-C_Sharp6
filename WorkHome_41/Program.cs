// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Ведите количество чисел (М): ");
int numbers = int.Parse(Console.ReadLine()!);
int[] array = InputNumbersArray(numbers);

Console.WriteLine($"{String.Join(", ", array)}");

Console.WriteLine($"Чисел больше нуля: {CountingPositiveNumbers(array)}");

int[] InputNumbersArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i +1}-ое число: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
} 

int CountingPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        count += numbers[i] > 0 ? 1 : 0;
    }
    return count;
}