// // Вид 1 — ничего не принимает, ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1(); // то, как мы вызываем метод данного типа, обязательно круглые скобки

// // Вид 2 — могут принимать аргументы, но не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(msg: "Текст", count: 4); // ("что хотим увидеть", сколько раз)
// //Method21(count: 4, msg: "новый текст"); // можно менять местами

// // Вид 3 — ничего не принимают, но возвращают
// int Method3() // в скобках пусто, потому что не принимает аргументы
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// // Console.WriteLine(year);

// // // Вид 4 — что-то принимает и что-то возвращает
// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     // string result = ""; // но правильнее будет написать String.Empty
// //     string result = String.Empty; // изначально строка - пустая 
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// // Применение цикла for
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++) // 1 инициализация, 2 проверка условия, 3 инкремент
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// // Console.WriteLine(res);


// // for (int i = 2; i <=10 ; i++) // внешний цикл используем счетчик i
// // {
// //     for (int j = 2; j <= 10 ; j++) // внутренний цикл используем счетчик j
// //     {
// //         Console.WriteLine($"{i} * {j} = {i * j}"); // интерполяция строк 
// //     }
// //     Console.WriteLine();
// // }



// // РЕШЕНИЕ ЗАДАЧ

// // Дан текст. В тексте все пробелы заменить черточками
// // Маленькие буквы "к" заменить большими "К"
// // А большие "С" заменить маленькими "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012345... 
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for(int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К'); // здесь мы обращаемся к newText, чтобы использовать то, что мы получили на предыдущем шаге 
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// выводим массив на экран 
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // мы начинаем с i + 1 (не трогаем отсортированное), а поэтому длина массива уже не array.Length, а array.Length - 1
    {
        int minPosition = i; // запоминаем позицию "рабочего элемента"

        // ищем максимальный элемент 
        for (int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        // замена переменных местами 
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
