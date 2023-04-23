using Lesson_17_18_S_Pravkami;

Console.WriteLine();
Console.Write("Укажите количество элементов массива: ");
int aae = Calculator.ReadFromConsoleAmountOfArrayElements(); //aae - amount of array elements
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задайте значения элементов массива: ");
Console.WriteLine();
int[] array = Calculator.ReadFromConsoleArray(aae);
Console.WriteLine();
Calculator.WriteTheEntireArray(array);
Console.WriteLine();
Console.WriteLine();

//1) Найти минимальный элемент массива.
Console.WriteLine();
Console.WriteLine("1. Нахождение минимального элемента массива.");
int min = Calculator.FindMinElementOfArray(array);
Console.WriteLine($"Минимальный элемент массива: {min}.");
Console.WriteLine();

//2) Найти максимальный элемент массива.
Console.WriteLine();
Console.WriteLine("2. Нахождение максимального элемента массива.");
int max = Calculator.FindMaxElementOfArray(array);
Console.WriteLine($"Максимальный элемент массива: {max}.");
Console.WriteLine();

//3) Найти индекс минимального элемента массива.
Console.WriteLine();
Console.WriteLine("3. Нахождение индекса минимального элемента массива.");
int minIndex = Calculator.FindMinIndex(array);
Console.WriteLine($"Индекс минимального элемента массива: {minIndex}.");
Console.WriteLine();

//4) Найти индекс максимального элемента массива.
Console.WriteLine();
Console.WriteLine("4. Нахождение индекса максимального элемента массива.");
int maxIndex = Calculator.FindMaxIndex(array);
Console.WriteLine($"Индекс максимального элемента массива: {maxIndex}.");
Console.WriteLine();

//5) Посчитать сумму элементов массива с нечетными индексами.
Console.WriteLine();
Console.WriteLine("5. Нахождение суммы элементов массива с нечётными индексами.");
int sum = Calculator.FindSum(array);
Console.WriteLine($"Сумма элементов массива с нечётными индексами: {sum}.");
Console.WriteLine();

//6) Сделать реверс массива (массив в обратном направлении).
Console.WriteLine();
Console.WriteLine("6. Создание обратного массива.");
int[] reverse = Calculator.Reverse(array);
Console.WriteLine();
Console.WriteLine("Зеркальное отображение введённого массива: ");
for (int j = 0; j < reverse.Length; j++)
{
    Console.WriteLine(reverse[j]);
}
Console.WriteLine();

//7) Посчитать количество нечетных элементов массива.
Console.WriteLine();
Console.WriteLine("7. Нахождение количества нечётных элементов массива и нечётных индексов массива.");
int sumOddElements = Calculator.FindSumOddElements(array);
Console.WriteLine();
Console.WriteLine($"Количество нечётных элементов массива: {sumOddElements}.");
Console.WriteLine();
int sumOddIndex = Calculator.FindSumOddIndex(array);
Console.WriteLine($"Количество нечётных индексов массива: {sumOddIndex}.");
Console.WriteLine();

//8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
Console.WriteLine();
Console.WriteLine("8. Перестановка половин массива.");
int[] swapHalves = Calculator.SwapHalves(array);
Console.WriteLine();
Console.WriteLine("Массив с поменянными местами половинами: ");
for (int j = 0; j < swapHalves.Length; j++)
{
    Console.WriteLine(swapHalves[j]);
}
Console.WriteLine();


//1) Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert))
Console.WriteLine();
Console.WriteLine("1. Сортировка массива по возрастанию методом пузырька.");
int[] increasingValue = Calculator.FindIncreasingValue(array);
Console.WriteLine();
Console.WriteLine("Массив, отсортированный по возрастанию: ");
for (int i = 0; i < increasingValue.Length; i++)
{
    Console.WriteLine(increasingValue[i]);
}
Console.WriteLine();

//2) Отсортировать массив по убыванию одним из способов, (отличным способом) : пузырьком(Bubble), выбором(Select) или вставками(Insert))
Console.WriteLine();
Console.WriteLine("2. Сортировка массива по убыванию методом вставки.");
int[] decreasingValue = Calculator.FindDecreasingValue(array);
Console.WriteLine();
Console.WriteLine("Массив, отсортированный по убыванию: ");
for (int i = 0; i < decreasingValue.Length; i++)
{
    Console.WriteLine(decreasingValue[i]);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Конец!");