/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] myArray(string step)
{
    string[] elements = new string[10];
    elements = step.Split(",");
    int[] arrayMy = new int[elements.Length];
    for (int i = 0; i < elements.Length; i++)
    {
        arrayMy[i] = int.Parse(elements[i]);

    }
    return arrayMy;
}

int CountNumbers(int[] inpCount) // Функция CountNumbers возвращающая целочисленное значение, в которую передали параметр массив(int[] inpCount) с целочисленными значениями(int). 
{
    int count = 0; // объявили переменную которая будет хранить количество элементов массива которые больше ноля.
    for (int i = 0; i < inpCount.Length; i++) // перебирает элементы массива от индекса = 0  и до указанного значеения(длинны массива)
    {
        if (inpCount[i] > 0) // если элемент массива больше 0, 
        {
            count += 1; // добавляем к count +1 
        }
    }
    return count; //выводим полученное значение
}

void main()
{
    Console.WriteLine("Введите 10 чисел через запятую: ");

    string num = Console.ReadLine()!;

    int[] inputCount = myArray(step: num);
    int rez = CountNumbers(inpCount: inputCount);
    Console.Write($"Чисел больше ноля {rez}");
}
main();



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//string[] myArray(string step)
//{
//    string[] elements = new string [10];
//    elements = step.Split(",");
//    return elements;
//}

//void CountNumbers(string[] elements)
//{
//    for (int i = 0; i <= ; i++)
//    {
//        
//    }
//    Console.WriteLine(String.Join(", ", elements));  
//}

//void main()
//{
//    Console.WriteLine("Введите 8 чисел через запятую: ");
//    string num = Console.ReadLine()!;
//    CountNumbers(myArray(num));
//   
//}

//main();



/*int CountNumbers(int num, int[] inputCount)
{
    int count = 0;
    for (int i = 0; i <= inputCount.Length; i++)
    {
        if (num > 0)
        {
        count += 1;
        }
    }
    return count;
}
void mainArray(string[] args)
{
    int[] mas = new int [5];
    int i = 0;
    string test;
    int count = 0;
    do
    {
        test = Console.ReadLine()!;
        if (test == "end") break;
        mas[i] = Convert.ToInt32(test);
        i++; count++;
    } while (true);
    Console.WriteLine("Вывод: ");
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{0} ", mas[j]);    
    }
    Console.ReadLine();
}
mainArray(args);

/*void main()
{
int[] inputSize = new int[5];
Console.WriteLine("Введите 5 чисел через запятую: ");
int[] num = Console.ReadLine();
CountNumbers(num,inputCount);
int count = CountNumbers(num, inputCount);
Console.WriteLine($"Количество чисел больше ноля -> {count}");
}
main();*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue);
    }
    return rez;
}

int sumOfArrayNumbers(int[] array)
{
    int element = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        element = element + array[i];
    }
    return element;
}
int[] array = GetArray(6, 1, 100);
Console.WriteLine(String.Join(", ", array));
int element = sumOfArrayNumbers(array);
Console.WriteLine($"Сумма элементов нечётных позиций -> {element}");*/