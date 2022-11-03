// I. Реализовать следующие функции для работы с массивами:
// заполнение и Вывод массива на экран
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}

// Поиск минимума
int MinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    return min;
}

// Поиск максимума
int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    return max;
}

// Поиск суммы элементов массива

int SumArray(int[] array)
{
    int sum = 0;
    foreach (int element in array)
        sum += element;
    return sum;
}
// Поиск произведения элементов массива

int ProductArrayElement(int[] array)
{
    int product = 1;
    foreach (int element in array)
        product *= element;
    return product;
}
// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1

int IndexSearch(int[] array, int search)
{
    int position = -1;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == search)
        {
            position = i;
            return position;
        }
    return position;
}
// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет

bool CheckingElementArray(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == find)
            return true;
    return false;
}
// Среднее арифметическое элеметов массива

float AverageArray(int[] array)
{
    return SumArray(array) / array.Length;
}
// Подсчёт количества отрицательных элементов массива

int NegativeElementsArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element < 0)
            count++;
    return count;
}
// Подсчёт количества положительных элементов в массиве

int PositiveElementsArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element > 0)
            count++;
    return count;
}
// Подсчёт количества вхождений элемента в массив

int Count(int[] array, int check)
{
    int count = 0;
    foreach (int element in array)
        if (check == element)
            count++;
    return count;
}
// Подсчёт количества чётных элементов в массиве

int EvenElements(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element % 2 == 0)
            count++;
    return count;
}
// Подсчёт количества нечётных элементов в массиве

int OddElements(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element % 2 == 1)
            count++;
    return count;
}
// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.

bool SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1])
            return false;
    return true;
}
// II. Реализовать следующие функции:
// Функцию, которая вычисляет число a в степени n

int DegreeNumber(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
        result *= number;
    return result;
}
// Функцию, которая вычисляет факториал числа n

int Factorial(int n)
{
    if (n != 0)
        return n * Factorial(n - 1);
    else
        return 1;
}
//Функцию, которая вычисляет сумму цифр произвольного целого числа n.

int SumDigits(int n)
{
    int sum = 0;
    foreach (char number in n.ToString())
        sum += int.Parse(number.ToString());
    return sum;
}

// Функцию, складывающую два целых числа

int Sum2Digits(int number1, int number2)
{
    return number1 + number2;
}

// Функцию, определяющую является ли число простым, 
// то есть возвращающую true, если число простое, иначе - false

bool PrimeNumber(int num)
{
    bool result = true;
    for (int i = 2; i < num; i++)
        if ((float)num / i == num / i)
            result = false;
    return result;
}

// Функцию, определяющую является ли число чётным, то есть возвращающую true, 
// если число чётное, иначе - false

bool EvenNumber(int digit)
{
    return digit % 2 == 0;
}

//III. Вызвать и проверить работу всех вышеуказанных фукнций

Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];


FillArray(array, -30, 30);
Console.WriteLine("Массив: ");


PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Минимальное значение: {MinValue(array)}");

Console.WriteLine($"Максимальное значение: {MaxValue(array)}");
Console.WriteLine();
Console.Write($"Сумма элементов массива равна: {SumArray(array)} ");
Console.WriteLine();
Console.Write($"Произведение элементов массива равна: {ProductArrayElement(array)} ");
Console.WriteLine();
Console.Write($"Среднее арифметическое элементов массива равно: {AverageArray(array)} ");
Console.WriteLine();
Console.Write($"Отрицательных элементов в массиве: {NegativeElementsArray(array)} ");
Console.WriteLine();
Console.Write($"Положительных элементов в массиве: {PositiveElementsArray(array)} ");
Console.WriteLine();
Console.Write($"Четных элементов в массиве: {EvenElements(array)} ");
Console.WriteLine();
Console.Write($"Нечетных элементов в массиве: {OddElements(array)} ");
Console.WriteLine();
Console.Write($"Является ли массив отсортированным: {SortedArray(array)} ");
Console.WriteLine();

Console.WriteLine();
Console.Write("Введите число для поиска индекса: ");
int search = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Индекс заданного числа равен: {IndexSearch(array, search)} ");
Console.WriteLine();

Console.WriteLine();
Console.Write("Введите число для проверки наличия в массиве: ");
int find = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Наличие данного числа в массиве: {CheckingElementArray(array, find)} ");
Console.WriteLine();

Console.WriteLine();
Console.Write("Введите число для подсчёта количества вхождений элемента в массив: ");
int check = int.Parse(Console.ReadLine() ?? "0");
int count = Count(array, check);
Console.WriteLine($"Число {check} встречается {count} раз(а)");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Для нахождения числа (a) в степени (n) ");
Console.Write("Введите число а: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число n: ");
int degree = int.Parse(Console.ReadLine() ?? "0");
int res = DegreeNumber(number, degree);
Console.Write($"Число {number} в степени {degree} равно {res}");
Console.WriteLine();

Console.WriteLine();
Console.Write("Для вычисления факториала введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Факториал числа {n} равен: {Factorial(n)} ");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Для получения суммы цифр произвольного целого числа введите это число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {num} равна: {SumDigits(num)}");
Console.WriteLine();

Console.WriteLine();
Console.Write("Для сложения двух целых чисел введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Если сложить числа {num1} и {num2}, то сумма будет равна: {Sum2Digits(num1, num2)}");
Console.WriteLine();

Console.Write("Введите число для определения является ли оно простым : ");
n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {n} является простым: {PrimeNumber(n)}");
Console.WriteLine();

Console.Write("Введите число для проверки на четность: ");
num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Является ли число {num} четным: {EvenNumber(num)}");