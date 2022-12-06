// void — метод, который ничего не возвращает
// не нуждается в операторе return 
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        // обращаемся к массиву с текущим индексо и кладем в него случайно 
        // сгенерированное число от 1 до 10
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // чтобы не было путаницы на случай "не найдено" 
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position; // возвращаем позицию элемента

}

// создаем массив, в котором будет 10 элементов
int[] array = new int[10]; // конструкция, определяющая, что в массиве 10 элементов 

// вызываем метод, который заполнит нам массив случайными числами
FillArray(array); 
// вызываем метод, который выведет на экран получившийся массив
PrintArray(array);
Console.WriteLine(); // пустая строчка-разделитель 

int pos = IndexOf(array, 444); // передаем массив в качестве аргумента, ищем 4
Console.WriteLine(pos);

