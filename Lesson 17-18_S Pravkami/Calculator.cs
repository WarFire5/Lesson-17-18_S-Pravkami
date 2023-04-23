namespace Lesson_17_18_S_Pravkami
{
    public static class Calculator
    {
        public static int ReadFromConsoleAmountOfArrayElements()
        {
            int aae = Convert.ToInt32(Console.ReadLine()); //aae - amount of array elements
            if (aae <= 0)
            {
                while (aae <= 0)
                {
                    Console.WriteLine(";");
                    Console.Write("Число элементов масива должно быть больше 0. Задайте корректное значение: ");
                    aae = Convert.ToInt32(Console.ReadLine());
                }
            }
            return aae;
        }
        public static int[] ReadFromConsoleArray(int aae)
        {
            int[] array = new int[aae];
            for (int i = 0; i < aae; i++)
            {
                Console.Write($"Присвойте {i}-му элементу значение: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(";");
            }
            return array;
        }
        public static void WriteTheEntireArray(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}-му элементу ");
                Console.Write($"соответствует значение {array[i]};");
                Console.WriteLine();
            }
        }

        //1) Найти минимальный элемент массива.
        public static int FindMinElementOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        //2) Найти максимальный элемент массива.
        public static int FindMaxElementOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //3) Найти индекс минимального элемента массива.
        public static int FindMinIndex(int[] array)
        {
            int minIndex = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //4) Найти индекс максимального элемента массива.
        public static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        //5) Посчитать сумму элементов массива с нечетными индексами.
        public static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        //6) Сделать реверс массива(массив в обратном направлении).
        public static int[] Reverse(int[] array)
        {
            int[] reverse = new int[array.Length];
            int temp = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse[temp] = array[i];
                temp++;
            }
            return reverse;
        }

        //7) Посчитать количество нечетных элементов массива.
        public static int FindSumOddElements(int[] array)
        {
            int sumOddElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumOddElements++;
                }
            }
            return sumOddElements;
        }
        public static int FindSumOddIndex(int[] arrayOdd)
        {
            int sumOddIndex = 0;
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddIndex++;
                }
            }
            return sumOddIndex;
        }

        //8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.        
        public static int[] SwapHalves(int[] array)
        {
            int temp = 0;
            int[] swapHalves = new int[array.Length];
            if (array.Length % 2 == 0)
            {
                for (int i = array.Length / 2; i < array.Length; i++)
                {
                    swapHalves[temp] = array[i];
                    temp++;
                }
                for (int j = 0; j < array.Length / 2; j++)
                {
                    swapHalves[temp] = array[j];
                    temp++;
                }
            }
            else
            {
                for (int i = array.Length / 2 + 1; i < array.Length; i++)
                {
                    swapHalves[temp] = array[i];
                    temp++;
                }
                swapHalves[temp] = array[array.Length / 2];
                temp++;
                for (int j = 0; j < array.Length / 2; j++)
                {
                    swapHalves[temp] = array[j];
                    temp++;
                }
            }
            array = swapHalves;
            return array;
        }


        //1) Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public static int[] FindIncreasingValue(int[] array)
        {
            int increasingValue;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        increasingValue = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = increasingValue;
                    }
                }
            }
            return array;
        }

        //2) Отсортировать массив по убыванию одним из способов, (отличным способом) : пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public static int[] FindDecreasingValue(int[] array)
        {
            int index;
            int decreasingValue;
            for (int i = 1; i < array.Length; i++)
            {
                index = i;
                decreasingValue = array[i];
                while (index > 0 && decreasingValue > array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = decreasingValue;
            }
            return array;
        }
    }
}
