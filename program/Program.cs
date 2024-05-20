using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива с клавиатуры
        Console.WriteLine("Введите элементы исходного массива через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        // Создание нового массива
        string[] newArray = new string[inputArray.Length];
        int newIndex = 0;

        // Формирование нового массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[newIndex] = inputArray[i];
                newIndex++;
            }
        }

        // Вывод нового массива
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < newIndex; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
