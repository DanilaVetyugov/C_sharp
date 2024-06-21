void PrintArrayFromEnd(int[] arr, int index)
{
    if (index < 0) return;
    Console.Write($"{arr[index]} ");
    PrintArrayFromEnd(arr, index - 1);
}

Console.WriteLine("Введите количество элементов в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArrayFromEnd(array, size - 1);