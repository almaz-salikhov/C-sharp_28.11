//метод заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); 
        index++;
    }
}

//метод, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//метод, который адаптирует поиск нужного элемента
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; 
    //переменная, в которую мы положим индекс нужного элемента, 
    //то есть положение в массиве)
    //для случаев, чтобы не путаться с индексом 0 и значением 0, 
    // когда нет ни одного подходящего варианта
    // -1 — это "такой элемент не найден"
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 1);
Console.WriteLine(pos);