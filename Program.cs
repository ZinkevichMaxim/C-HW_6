1. GetArray
2. PrintArray
3. ДВА СПОСОБА РАЗВОРОТА МАССИВА void & return
4. Prompt c проверкой
5. Перевод десятичных чисел в двоичные
6. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
7. Напишите программу, которая будет преобразовывать десятичное число в двоичное. НЕСКОЛЬКО РЕШЕНИЙ
8. Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
9.  Не используя рекурсию, выведите первые N чисел Фибоначчи. 


Console.Clear();
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] array = GetArray(10, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// ReversArray1(array);
// PrintArray(array);
// int[] reversArray = ReverseArray2(array);
// Console.WriteLine();
// PrintArray(reversArray);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = k;
//     }
// }

// int[] ReverseArray2(int[] inArray)
// {
//     int[] res = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         res[i] = inArray[inArray.Length - 1 - i];
//     }
//     return res;
// }


Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// &&  = и

// int Prompt (string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     if ((int.TryParse(value, out int val)) == false)
//     {
//         Console.WriteLine("Это не число ");
//     }
//     return val;
// }

// int a = Prompt("Введите первое значение: ");
// int b = Prompt("Введите второго значение: ");
// int c = Prompt("Введите третье значение: ");

// if (a<(b+c) && b<(a+c) && c<(a+b))
// {
//     Console.WriteLine("Треугольник с такими сторонами монжно задать.");
// }
// else
// {
//     Console.WriteLine("Треугольник с такими сторонами Нельзя задать.");    
// }


Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int Reader()
// {
//     Console.WriteLine("enter your number: ");
//     if (int.TryParse(Console.ReadLine(), out int num) == false || num < 0)
//     {
//         num = -1;
//         return num;
//     }
//     else
//     {
//         return num;
//     }
// }

// int CountDifiner (int num)
// {
//     int count = 0;
//     while (num != 0)
//     {
//         num = num / 2;
//         count++;
//     }
//     return count;
// }

// int[] BinaryNumConverter (int num, int count)
// {
//     int[] binaryNum = new int[count];
//     for (int i = count - 1; i >= 0; i--)
//     {
//         int temp = num % 2;
//         num /= 2;
//         binaryNum[i] = temp;
//     }
//     return binaryNum;
// }

// void PrintBinary (int[] binary)
// {
//     for (int i = 0; i < binary.Length; i++)
//     {
//         Console.Write(binary[i]);
//     }
// }

// int num = Reader();
// int count = CountDifiner(num);
// PrintBinary(BinaryNumConverter(num, count));

Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.


// int Prompt (string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     if ((int.TryParse(value, out int val)) == false) проверка на строку. Фиксированная команда
//     {
//         Console.WriteLine("Это не число ");
//     }
//     return val;
// }

// int[] CreateRandomMassive(int val)
// {
//     // int [] array = new int [8];
//     int [] array = new int [val];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);  // генератор [a,b)
//         // Console.Write (array[i]+" ");
//     }
//     return array;
// }

// void PrintMassive(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write (array[i]+" ");
//     }
//     Console.WriteLine ();
// }

// int val = Prompt("Введите количество элементов массива: ");
// int[] origin = CreateRandomMassive(val);

// int[] copy = new int[val];
// for (int i=0; i<val; i++)
// {
//     copy [i] = origin [i];
// }

// PrintMassive(origin);
// Console.WriteLine ("----------- ");
// PrintMassive(copy);

Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear ();

// int Prompt (string msg)
// {
//     Console.Write(msg);
//     string value = Console.ReadLine();
//     if ((int.TryParse(value, out int val)) == false)
//     {
//         Console.WriteLine("Это не число ");
//     }
//     return val;
// }

// int n = Prompt("Введите количество элементов: ");
// int num1 = 0;
// int num2 = 1;
// int num = 0;
// Console.Write($"{0}, {1}");
// for(int i=3;i<=n;i++)
// {
//     num=num1+num2;
//     num1= num2;
//     num2=num;
//     Console.Write($", {num}");
// }

Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int Input()
// {
//     Console.Write("Введите: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int[] Solution(int num)
// {
//     int[] res = new int[] {};
//     int i = 0;
//     while (num > 0)
//     {   
//         Array.Resize(ref res, res.Length + 1);    
//         res[i] = num % 2;
//         num = num /2;
//         i++;    
//     }
//     return res;
// }
// int[] ReverseArray2(int[] inArray)
// {
//     int[] res = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         res[i] = inArray[inArray.Length - 1 - i];
//         Console.Write($"{res[i]}");
//     }
//     return res;
// }
// int num1 = Input();
// int[] newArray = Solution(num1);
// ReverseArray2(newArray);

еще вариант
int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Convert10To2(int num)
{
    int res = 0;
    string showresult = string.Empty;
    while (num > 0)
    {
        res = num % 2;
        num /= 2;
        showresult = res + showresult; // 0 + "пустое значени" // 0+0 // 0+00 // 1+000//
    }
    Console.WriteLine();
    Console.WriteLine(showresult);

}

int a = InPutNum("Введите число");
Convert10To2 (a);


И ТРЕТИЙ ВАРИАНТ

int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Convert10To2(int num)
{
    int res = 0;
    string showresult = string.Empty;
    while (num > 0)
    {
        res = num % 2;
        num /= 2;
        showresult = res + showresult; // 0 + "пустое значени" // 0+0 // 0+00 // 1+000//
    }
    Console.WriteLine();
    Console.WriteLine(showresult);

}

int a = InPutNum("Введите число");
Convert10To2 (a);



ФОРМУЛА ДЛЯ ДЗ
Точка пересечения (x, y) = ((b1×c2 − b2×c1)/(a1×b2 − a2×b1), (c1×a2 − c2×a1)/(a1×b2 − a2×b1)) есть в чате в самом конце семинара
