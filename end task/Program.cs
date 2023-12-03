// Ввод массива строк
Console.WriteLine("Введите строки через запятую:");
string[] inputArray = Console.ReadLine().Split(',');

// Фильтрация массива
string[] resultArray = FilterArray(inputArray);

// Вывод результата
Console.WriteLine("Результат:");
foreach (var item in resultArray)
{
    Console.Write($"{item} ");
}
    

    static string[] FilterArray(string[] inputArray)
{
    int count = 0;
    // Подсчет строк, подходящих под условие
    foreach (var item in inputArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива
    string[] resultArray = new string[count];
    int index = 0;

    // Заполнение нового массива
    foreach (var item in inputArray)
    {
        if (item.Length <= 3)
        {
            resultArray[index] = item;
            index++;
        }
    }

    return resultArray;
}