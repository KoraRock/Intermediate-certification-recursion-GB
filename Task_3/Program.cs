//Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

void PrintArrayRec(int[] array, int index = 0)
{
    int size = array.Length;
    if (index < size)
    {
        PrintArrayRec(array, index + 1);
        Console.Write (array[index] + " ");
    }
}
int[] CreateArray(string args)
{
    int[] numbers;
    if (args.Length >= 1)
    {
        string[] Elements = args.Split(' ');
        numbers = new int[Elements.Length];
        for (int j = 0; j < Elements.Length; j++)
                {
                    if (int.TryParse(Elements[j], out int result))
                    {
                        numbers[j] = result;
                    }
                }
        return numbers;

    }
    return numbers = [0];
    
}

Console.WriteLine("Введите значения параметров массива через пробел:");
string str = Console.ReadLine();

PrintArrayRec(CreateArray(str));
