// Сортировка выбором

// Заполнение массива
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Сортировка
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[minIndex])
            minIndex = j;
    }
    int temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");


// Сортировка массива строк
/*
string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 4; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < 5; j++)
    {
        if (array[j].Length < array[MinIndex].Length)
            MinIndex = j; 
    }
    string temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
*/
/*
int [] newArray = new int [] {5, 3, 7, 4, 6};
Console.WriteLine("Начальный массив: [" + string.Join(", ", newArray) + "]");
Console.WriteLine();

int k = 3;
int temp;

for (int i = k - 1; i < newArray.Length; i++)
{
    for (int j = 0; j < newArray.Length; j++)
    {
        temp = newArray[j];
        newArray[j] = newArray[i];
        newArray[i] = temp;
    }
    
}

Console.WriteLine("Конечный массив: [" + string.Join(", ", newArray) + "]");
*/