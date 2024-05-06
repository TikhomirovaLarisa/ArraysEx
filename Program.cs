internal class Program
{
    private static void Main(string[] args)
    {
        int userArrayLength = InputNumber("Введите количество элементов массива: ");
        string[] userArray = CreateUserArray(userArrayLength);
        int maxElementLength = InputNumber("Введите число максимальной длины элементов нового массива: ");
        string[] newArray = CreateArray(SearchElements(userArray, maxElementLength));

        FillArray(newArray, userArray, maxElementLength);
        Console.WriteLine("Массив заданных элементов:");
        PrintArray(userArray);
        Console.WriteLine("Массив отсортированных элементов:");
        PrintArray(newArray);
    }
    static int InputNumber(string message) // Получение числа от пользователя.
    {
        Console.Write(message);
        int value;
        if (int.TryParse(Console.ReadLine(), out value)) return value;
        Console.WriteLine("Вы ввели не число");
        Environment.Exit(1);
        return 0;
    }

    static string InputString(string message) // Получение строки от пользователя.
    {
        Console.Write($"{message}");
        return Console.ReadLine();
    }

    static string[] CreateUserArray(int size) // Создание пользователем одномерного массива из строк
    {
        string[] array = new string[size];
        int element = 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = InputString($"Введите {element} элемент массива: ");
            element++;
        }
        return array;
    }

    static int SearchElements(string[] array, int max) // Поиск элементов массива.
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= max) count++;
        }
        return count;
    }

    static string[] CreateArray(int size) // Создание одномерного массива.
    {
        string[] array = new string[size];
        return array;
    }

    static string[] FillArray(string[] newArray, string[] array, int max) // Заполнение массива элементами
    {
        int j = 0;
        for (int k = 0; k < array.Length; k++)
        {

            if (array[k].Length <= max)
            {
                newArray[j] = array[k];
                j++;
            }
        }
        return newArray;
    }

    static void PrintArray(string[] array) // Вывод  массива в консоль.
    {
        Console.Write("{ ");
        foreach (var item in array)
        {
            Console.Write($"{item}, ");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}