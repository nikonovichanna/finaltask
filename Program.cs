Console.WriteLine("Введите элементы массива через запятую:");
string[] inputArray = Console.ReadLine().Split(',');
string[] outputArray = FilterArray(inputArray);
Console.WriteLine("Новый массив:");
PrintArray(outputArray);

string[] FilterArray(string[] arr)
{
    int count = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }

    string[] newArr = new string[count];
    int index = 0;

    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            newArr[index] = item;
            index++;
        }
    }

    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(']');
}