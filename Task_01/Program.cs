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
