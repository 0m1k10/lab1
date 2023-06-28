// 1. Дан список чисел. Порахуйте, скільки в ньому пар елементів, рівних один одному. Вважається, що будь-які два елементи, рівні один одному, утворюють одну пару, яку необхідно порахувати

using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Список чисел на входе 
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 1, 4 };

        // Подсчета вхождения каждого числа
        Dictionary<int, int> count = new Dictionary<int, int>();

        // Подсчет кол-ва входа каждого числа в списке
        foreach (int number in numbers)
        {
            if (count.ContainsKey(number))
            {
                count[number]++;
            }
            else
            {
                count[number] = 1;
            }
        }

        // Считаем кол-во пар
        int pairsCount = 0;
        foreach (int value in count.Values)
        {
            pairsCount += value / 2;
        }

        // Результат
        Console.WriteLine("Кол-во элементов в списке: " + pairsCount);
    }
}

// 2. Перемножити всі значення ключів словника і відсортувати його за значеннями. Вивести сортований словник у JSON
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;

//class Program
//{
//    static void Main()
//    {
//        // Создание словаря 
//        Dictionary<string, int> dict = new Dictionary<string, int>
//        {
//            { "A", 2 },
//            { "B", 8 },
//            { "C", 1 },
//            { "D", 5 },
//            { "E", 9 }
//        };
//        // Перемножаем значения ключей 
//        int result = 1;
//        foreach (int value in dict.Values)
//        {
//            result *= value;
//        }
//        // Сортиование словаря по значениям 
//        var sortedDict = dict.OrderBy(kv => kv.Value);
//        // Выведение отсортированного словаря 
//        foreach (var entry in sortedDict)
//        {
//            Console.WriteLine(entry.Key + ": " + entry.Value);
//        }
//        // Сохранения сортированного словаря в JSON 
//        string json = JsonSerializer.Serialize(sortedDict);
//        File.WriteAllText("sortedDict.json", json);
//        // Выведение результата умножений 
//        Console.WriteLine("Результат перемноження зачений: " + result);
//    }
//}


// 3. Дано символ С і строкова послідовність A. Знайти кількість елементів A, які містять більше одного символу і при цьому починаються і закінчуються символом C

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        char symbolC = 'C';
//        string[] sequenceA = { "Cat", "Dog", "Car", "Bird", "Coconut", "Cake", "", "" };

//        int count = sequenceA.Count(s => s.Length > 1 && s.First() == symbolC && s.Last() == symbolC);

//        Console.WriteLine("Кол-во элементов A, которые содержат больше одного символа и начинаются/заканчиваются символом C: " + count);
//    }
//}
