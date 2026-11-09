using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        main0();
    }
    static void main0()
    {
        while (true)
        {
            Console.WriteLine("Выберите лабораторную работу которую хотите проверить (от 4 до 10): ");
            Console.WriteLine("Введите exit если хотите выйти из программы");
            string f = Console.ReadLine() ?? "";
            if (f == "4")
            {
                Console.WriteLine();
                main40();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main50();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main60();
            }
            else if (f == "7")
            {
                Console.WriteLine();
                main70();
            }
            else if (f == "8")
            {
                Console.WriteLine();
                main80();
            }
            else if (f == "9")
            {
                Console.WriteLine();
            }
            else if (f == "10")
            {
                Console.WriteLine();
            }
            else if (f == "exit")
            {
                Console.WriteLine("Выход из программы...");
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
static void main40()
    {
        Console.WriteLine("Лабораторная работа №4. Одномерные массивы");
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 8 или \"Back\" чтобы вернуться к выбору лабораторной работы");
            Console.Write("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                Console.WriteLine();
                main41();
            }
            else if (f == "2")
            {
                Console.WriteLine();
                main42();
            }
            else if (f == "3")
            {
                Console.WriteLine();
                main43();
            }
            else if (f == "4")
            {
                Console.WriteLine();
                main44();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main45();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main46();
            }
            else if (f == "7")
            {
                Console.WriteLine();
                main47();
            }
            else if (f == "8")
            {
                Console.WriteLine();
                main48();
            }
            else if (f == "Back" || f == "back")
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
    static void main50()
    {
        Console.WriteLine("Лабораторная работа №5. Двумерные массивы (матрицы)");
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 7 или \"Back\" чтобы вернуться к выбору лабораторной работы");
            Console.Write("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                Console.WriteLine();
                main51();
            }
            else if (f == "2")
            {
                Console.WriteLine();
                main52();
            }
            else if (f == "3")
            {
                Console.WriteLine();
                main53();
            }
            else if (f == "4")
            {
                Console.WriteLine();
                main54();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main55();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main56();
            }
            else if (f == "7")
            {
                Console.WriteLine();
                main57();
            }
            else if (f == "Back" || f == "back")
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
    static void main60()
    {
        Console.WriteLine("Лабораторная работа №6. Строки и символьные массивы");
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 7 или \"Back\" чтобы вернуться к выбору лабораторной работы");
            Console.Write("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                Console.WriteLine();
                main61();
            }
            else if (f == "2")
            {
                Console.WriteLine();
                main62();
            }
            else if (f == "3")
            {
                Console.WriteLine();
                main63();
            }
            else if (f == "4")
            {
                Console.WriteLine();
                main64();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main65();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main66();
            }
            else if (f == "7")
            {
                Console.WriteLine();
                main67();
            }
            else if (f == "Back" || f == "back")
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
    static void main70()
    {
        Console.WriteLine("Лабораторная работа №7. Функции и рекурсия");
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 6 или \"Back\" чтобы вернуться к выбору лабораторной работы");
            Console.Write("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                Console.WriteLine();
                main71();
            }
            else if (f == "2")
            {
                Console.WriteLine();
                main72();
            }
            else if (f == "3")
            {
                Console.WriteLine();
                main73();
            }
            else if (f == "4")
            {
                Console.WriteLine();
                main74();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main75();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main76();
            }
            else if (f == "Back" || f == "back")
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
    static void main80()
    {
        Console.WriteLine("Лабораторная работа №8. Сортировка и поиск (продвинутый уровень)");
        while (true)
        {
            Console.WriteLine("Выберите задание которое хотите проверить (от 1 до 6 или \"Back\" чтобы вернуться к выбору лабораторной работы");
            Console.Write("Введите цифру задания которое хотите проверить: ");
            string f = Console.ReadLine() ?? "";
            if (f == "1")
            {
                Console.WriteLine();
                main81();
            }
            else if (f == "2")
            {
                Console.WriteLine();
                main82();
            }
            else if (f == "3")
            {
                Console.WriteLine();
                main83();
            }
            else if (f == "4")
            {
                Console.WriteLine();
                main84();
            }
            else if (f == "5")
            {
                Console.WriteLine();
                main85();
            }
            else if (f == "6")
            {
                Console.WriteLine();
                main86();
            }
            else if (f == "Back" || f == "back")
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Ошибка: введено недопустимое значение. Повторите ввод");
                Console.WriteLine();
                continue;
            }
        }
    }
    static void main41()
    {
        Console.WriteLine("Заполнить массив случайными числами и вывести его на экран.");
        int[] a =[225,523,6,234,6723,24,623,623,845];
        for(int i = 0,b; i < a.Length; i++)
        {
        b=a[i];
        Console.Write($"{b} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static void main42()
    {
        int indexmax=0,indexmin=0;
        Console.WriteLine("v");
        int[] a =[225,523,6,234,6723,24,623,623,845];
        int max = a[1], min = a[1];
        for(int i = 0,b; i < a.Length; i++)
        {
            b=a[i];
            if(b>max){max=b;indexmax=i;}
            if(b<min){min=b;indexmin=i;}
        }
        Console.WriteLine($"Максимальный массив {max} с индексом {indexmax}");
        Console.WriteLine($"Минимальный массив {min} с индексом {indexmin}");
        Console.WriteLine();
    }
static void main43()
    {
        int sum=0,arif;
        Console.WriteLine("Вычислить сумму и среднее арифметическое элементов массива.");
        int[] a =[225,523,6,234,6723,24,623,623,845];
        int max = a[1], min = a[1];
        for(int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        arif=sum/a.Length;
        Console.WriteLine($"Среднее арифметическое: {arif}");
        Console.WriteLine($"Сумма всех элементов массива: {sum}");
        Console.WriteLine();
    }
static void main44()
    {
        int noch=0,ch=0;
        Console.WriteLine("Подсчитать количество чётных и нечётных элементов массива.");
        int[] a =[225,523,6,234,6723,24,623,623,845];
        int max = a[1], min = a[1];
        for(int i = 0,b; i < a.Length; i++)
        {
            b=a[i];
            if(b%2==0){ch++;}
            else {noch++;}
        }
        Console.WriteLine($"Количество четных: {ch}");
        Console.WriteLine($"Количество нечетных: {noch}");
        Console.WriteLine();
    }
static void main45()
    {
        Console.WriteLine("Реализовать реверс массива (изменить порядок элементов на обратный) без использования дополнительного массива.");
        int[] a =[225,523,6,234,6723,24,623,623,845,845];
        for(int i = 0; i < a.Length/2; i++)
        {
            int j = a.Length - 1 - i;
            int b = a[i];
            a[i] = a[j];
            a[j] = b;
        }
        for(int i = 0,b; i < a.Length; i++)
        {
            b=a[i];
            Console.Write($"{b} ");
        }
        Console.WriteLine();
    }
    static void main46()
    {
        Console.WriteLine("Удалить из массива все элементы, кратные заданному числу, со сдвигом оставшихся.");
        int?[] a ={225,523,6,234,6723,24,623,623,845,845};
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i]%2==0){a[i]=null;}
        }
        for(int i = 0,index=0; i < a.Length; i++)
        {
            if(a[i]!=null){a[i]=a[index];index++;}
        }
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i]==null){Console.Write($"null ");}
            else {Console.Write($"{a[i]} ");}
        }
        Console.WriteLine();
    }
    static void main47()
    {
        Console.WriteLine("Реализовать сортировку массива методом пузырька и методом выбора; сравнить количество операций сравнения.");
        int[] a ={225,523,6,234,6723,24,623,623,845,845};
        int indexmin = 0;
        int min = a[indexmin];
        int comparision=0;
        //метод выборки
        for(int j = 0;j<a.Length; j++)
        {
            if (a[j] < min)
            {
                indexmin=j;
                min=a[indexmin];
            }
        }
        for(int i = 0; i<a.Length; i++)
        {
            if (a[i] > min)
            {
                (a[i],a[indexmin])=(a[indexmin],a[i]);
                comparision++;
                indexmin=comparision;
                min=a[comparision];
                for(int j = comparision;j<a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        indexmin=j;
                        min=a[indexmin];
                    }
                }
                i=0;
            }
        }
        Console.Write($"Массив отсортированный методом выборки: ");  
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }
        //метод пузырька
        int[] b = {225,523,6,234,6723,24,623,623,845,845};
        for(int i = 1; i < b.Length; i++)
        {
            if (b[i - 1] > b[i])
            {
                (b[i - 1],b[i])=(b[i],b[i - 1]);
                i=0;
            }
        }
        Console.WriteLine();
        Console.Write($"Массив отсортированный методом пузырька: "); 
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{b[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
        /*Вариант нейросети:
    {
        Console.WriteLine("Сортировка выбором и пузырьком; сравнение количества сравнений.");

        int[] original = { 225, 523, 6, 234, 6723, 24, 623, 623, 845, 845 };

        // ============================================================
        // 1. СОРТИРОВКА ВЫБОРОМ
        // ============================================================
        int[] a = (int[])original.Clone();
        int selectionComparisons = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                selectionComparisons++;                 // считаем КАЖДОЕ сравнение
                if (a[j] < a[minIdx]) minIdx = j;
            }
            if (minIdx != i)
                (a[i], a[minIdx]) = (a[minIdx], a[i]);  // своп через кортеж
        }

        Console.WriteLine($"\nВыбор: сравнений = {selectionComparisons}");
        Console.Write("Результат: ");
        for (int k = 0; k < a.Length; k++) Console.Write($"{a[k]} ");
        Console.WriteLine();

        // ============================================================
        // 2. СОРТИРОВКА ПУЗЫРЬКОМ (классическая, с флагом swapped)
        // ============================================================
        int[] b = (int[])original.Clone();
        int bubbleComparisons = 0;

        for (int i = 0; i < b.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < b.Length - 1 - i; j++)
            {
                bubbleComparisons++;                    // считаем КАЖДОЕ сравнение
                if (b[j] > b[j + 1])
                {
                    (b[j], b[j + 1]) = (b[j + 1], b[j]);
                    swapped = true;
                }
            }
            if (!swapped) break;                        // уже отсортирован — досрочный выход
        }

        Console.WriteLine($"\nПузырёк: сравнений = {bubbleComparisons}");
        Console.Write("Результат: ");
        for (int k = 0; k < b.Length; k++) Console.Write($"{b[k]} ");
        Console.WriteLine();
        Console.WriteLine();
    }
        */
    static void main48()
    {
        Console.WriteLine("Реализовать бинарный поиск элемента в отсортированном массиве и сравнить с линейным поиском по числу итераций.");
        int[] a = {6, 24, 225, 234, 523, 623, 623, 845, 845, 6723};
        int number;
        bool nosearch=true;
        int linearIterations = 0;
        while (true)
        {
            Console.Write("Введите целое число: ");
            string userinput = Console.ReadLine() ?? "";
            if (int.TryParse(userinput, out number))
                break;                                  
            Console.WriteLine("Ошибка ввода, перезапуск");
        }
        //Линейный поиск
        for(int i = 0; i < a.Length; i++)
        {
            linearIterations++;
            if(a[i]==number)
            {
                Console.WriteLine($"Искомое число {number} находится под индексом {i}");
                Console.WriteLine($"Количество итераций линейного поиска: {linearIterations}");
                nosearch=false;break;
            }
        }
        linearIterations = 0;
        //бинарный поиск
        if(number>a[a.Length/2])
        {
            for(int i = a.Length/2; i < a.Length; i++)
            {
                linearIterations++;
                if(a[i]==number)
                {
                    Console.WriteLine($"Искомое число {number} находится под индексом {i}");
                    Console.WriteLine($"Количество итераций бинарного поиска: {linearIterations}");
                    nosearch=false;break;
                }
            }
        }
        else if(number<a[a.Length/2])
        {
            for(int i = a.Length/2; i > -1; i--)
            {
                linearIterations++;
                if(a[i]==number)
                {
                    Console.WriteLine($"Искомое число {number} находится под индексом {i}");
                    Console.WriteLine($"Количество итераций бинарного поиска: {linearIterations}");
                    nosearch=false;break;
                }
            }
        }
        else if (number == a[a.Length/2])
        {
            Console.WriteLine($"Искомое число {number} находится под индексом {a.Length / 2}");
            Console.WriteLine($"Количество итераций бинарного поиска: {linearIterations}");
            nosearch=false;
        }
        if(nosearch){Console.WriteLine($"Искомое число {number} не найдено");}
        Console.WriteLine();
    }
    static void main51()
    {
        Console.WriteLine("Заполнить матрицу размером MxN случайными числами и вывести её в табличном виде.");
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        Console.WriteLine("Таблица массива MxN:");
        Console.WriteLine();
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void main52()
    {
        Console.WriteLine("Найти сумму элементов главной и побочной диагоналей квадратной матрицы.");
        int sum=0;
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        for(int i=0; i < a.GetLength(0); i++)
        {
            sum+=a[i,i];
        }
        for(int j = 0,i=0; i < a.GetLength(0); j++,i++)
        {
            int n=a.GetLength(0);
            int l=n-1-i;
            sum+=a[i,l];
        }
        Console.WriteLine($"Сумма элементов главной и побочной диагоналей квадратной матрицы: {sum}");
        Console.WriteLine();
    }
    static void main53()
    {
        Console.WriteLine("Найти максимальный элемент в каждой строке и в каждом столбце матрицы.");
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        Console.WriteLine();
        for(int j = 0; j < a.GetLength(0); j++)
        {
            int max=a[j,0];
            for(int i = 0; i < a.GetLength(1); i++)
            {

                if(max<a[j,i]){max=a[j,i];}

            }
            Console.WriteLine($"Максимальный элемент строки {j+1}: {max} ");
        }
        Console.WriteLine();
        for(int i = 0; i < a.GetLength(0); i++)
        {
            int max=a[0,i];
            for(int j = 0; j < a.GetLength(1); j++)
            {

                if(max<a[j,i]){max=a[j,i];}

            }
            Console.WriteLine($"Максимальный элемент столбца {i+1}: {max} ");
        }
        Console.WriteLine();
    }
    static void main54()
    {
    Console.WriteLine("Реализовать транспонирование матрицы.");
    int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        for(int i = 0; i < a.GetLength(0); i++)
        {
            for(int j = i+1; j < a.GetLength(0); j++)
            {
                int temp = a[i,j];
                a[i,j]=a[j,i];
                a[j,i]=temp;
            }
        }
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void main55()
    {
    Console.WriteLine("Реализовать сложение и умножение двух матриц.");
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        int[,] b = new int[6, 6]{
            { 431,   7, 288, 164, 493,  22 },
            { 377, 119, 455,  64, 203, 341 },
            {  98, 418, 275,  46, 399, 152 },
            { 487, 231,  73, 358, 112, 264 },
            {  35, 443, 189, 306,  57, 471 },
            { 138, 322,  84, 412, 218, 384 }
        };
        int[,] c = new int[6, 6];
        int sum = 0;
        Console.WriteLine();
        Console.WriteLine("Таблица A:");
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Таблица B:");
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                Console.Write($"{b[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                c[i,j]=a[i,j]+b[i,j];
            }
        }
        Console.WriteLine("Таблица C после cложения таблиц A и B:");
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                Console.Write($"{c[j,i]} ");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
        for(int i = 0; i < c.GetLength(0); i++)
        {
            for(int j = 0; j < c.GetLength(1); j++)
            {
                for(int l = 0; l < c.GetLength(0); l++)
                {
                    sum+=a[i,l]*b[l,j];
                }
                c[i,j]=sum;
                sum=0;
            }
        }
        Console.WriteLine("Таблица C после матричного умножения таблиц A и B:");
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                Console.Write($"{c[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                c[i,j]=a[i,j]*b[i,j];
            }
        }
        Console.WriteLine("Таблица C после умножения Адамара таблиц A и B:");
        for(int j = 0; j < c.GetLength(0); j++)
        {
            for(int i = 0; i < c.GetLength(1); i++)
            {
                Console.Write($"{c[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void main56()
    {
    Console.WriteLine("Отсортировать строки матрицы по возрастанию суммы элементов каждой строки.");
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        Console.WriteLine("Текущая таблица:");
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Отсортированная по возрастанию таблица:");
        for(int l=0;l < a.GetLength(0);l++){
            for(int i = 0, comparision=0, j = 0; i < a.GetLength(0); )
            {
                int min=a[l,i];
                int indexmin=i;
                for(; j < a.GetLength(0); j++) 
                {   
                    if (a[l,j] < min)
                    {
                        min=a[l,j];
                        indexmin=j;
                    }
                }
                if (a[l,i] > min)
                {
                    (a[l,i], a[l,indexmin]) = (a[l,indexmin], a[l,i]);
                }
                comparision++;
                i=comparision;
                j=comparision;
            }
        }
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void main57()
    {
        Console.WriteLine("Реализовать алгоритм «змейка» — вывод элементов матрицы по спирали.");
        int[,] a = new int[6, 6]{
            { 427,  83, 156, 291, 348, 211 },
            {  62, 419, 174, 305,  88, 334 },
            { 241,  97, 362, 143, 478, 492 },
            {  15, 226, 391,  59, 314,  67 },
            { 183, 447,  72, 268, 125, 279 },
            { 405,  38, 219, 356, 168, 396 }
        };
        Console.WriteLine("Текущая таблица:");
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int comparision=0;
        bool H=true;
        bool F=false;
        bool D=false;
        int[,] temp = new int[6, 6];
        for(int i = 0,j = 0,l = 0,i1 = 0,i2 = 0; i < a.Length; i++)
        {
        if (i2 == (a.GetLength(0)-comparision)&& H==true)
        {
            i2=5-comparision;i1++;
            if(i1 == (a.GetLength(0) - comparision))
            {
                i1=5-comparision;
                H=false;F=true;
            }
        }
        if (D)
        {
            i1--;
            if (i1 == comparision)
            {
                H=true;D = false;
            }
        }
        if (i1 < (a.GetLength(0)-comparision)&& F==true)
        {
            i2--;
            if (i2 == comparision)
            {
                comparision++;
                F=false;D = true;
            }
        }
            if(l==temp.GetLength(0)){l=0;j++;}
            temp[j,l] = a[i1,i2];
            l++;
            if(H){i2++;}
        }
        a=temp;
        Console.WriteLine("Матрица выведенная методом спирали:");
        for(int j = 0; j < a.GetLength(0); j++)
        {
            for(int i = 0; i < a.GetLength(1); i++)
            {
                Console.Write($"{a[j,i]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void main61()
    {
        Console.WriteLine("Подсчитать количество гласных, согласных и цифр в строке.");
        const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
        string stroka = "Интернет вымирает";
        int glasniestr =0;
        int soglasniestr =0;
        int cifra =0;
        for (int i = 0; i < stroka.Length; i++)
        {
        char temp = stroka[i];
        if (char.IsDigit(temp))
        {
            cifra++;
        }
        else if (char.IsLetter(temp))
        {
            if (glasnie.IndexOf(temp) >= 0)
            glasniestr++;
            else
            soglasniestr++;
        }
        }
        Console.WriteLine($"Количество гласных: {glasniestr}");
        Console.WriteLine($"Количество согласных: {soglasniestr}");
        Console.WriteLine($"Количество цифр: {cifra}");
    }
/*char c = 'а';
const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
char.IsDigit(c);        // true для '0'..'9' (и для цифр других письменностей, см. ниже)
char.IsLetter(c);       // true для любой буквы Unicode
char.IsLetterOrDigit(c); // true для буквы или цифры
char.IsWhiteSpace(c);   // true для пробела, \t, \n и т.д.
char.IsPunctuation(c);  // true для ., , ! ? и т.п. */
    static void main62()
    {
        Console.WriteLine("Определить, является ли строка палиндромом (без учёта регистра и пробелов).");
        string stroka = "шалаш";
        bool palindrom=true;
        {
            string temp=stroka;
            temp=temp.Replace(" ","");
            temp=temp.ToLower();
            for (int i = 0; i < temp.Length/2; i++)
            {
                if(!(temp[i]==temp[temp.Length - 1 - i]))
                {
                    palindrom=false;
                    break;
                }
            }
        }
        if(palindrom) Console.WriteLine("Текущая строка является палиндромом.");
        else Console.WriteLine("Текущая строка не является палиндромом.");
    }
    static void main63()
    {
        Console.WriteLine("Реализовать подсчёт количества вхождений заданного символа/подстроки в строку.");
        string stroka = "шалаш";
        string userinput;
        while (true)
        {
            Console.Write("Введите строку: ");
            userinput = Console.ReadLine() ?? "";
            if (!string.IsNullOrEmpty(userinput))
            break;
            Console.WriteLine("Пустой ввод, попробуйте ещё раз.");
        }
        int pos=0;
        int count=0;
        while ((pos = stroka.IndexOf(userinput, pos)) != -1)
        {
           count++;
            pos++;
        }
        Console.WriteLine($"В строке \"{stroka}\" вхождений заданного \"{userinput}\" : {count}");
    }
    static void main64()
    {
        Console.WriteLine("Удалить из строки все повторяющиеся пробелы.");
        string stroka = "ш  ал    аш";
        stroka = stroka.Replace(" ", "");
        Console.WriteLine($"Новая строка: {stroka}");
    }
    static void main65()
    {
        Console.WriteLine("Реализовать разворот каждого слова в строке с сохранением их порядка.");
        string[] stroka = { "шалаш", "вода", "дом", "чебурнет" };
        static string ReverseWord(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        for (int i = 0; i < stroka.Length; i++)
        {
            stroka[i] = ReverseWord(stroka[i]);
        }
        Console.WriteLine(string.Join(" ", stroka));
    }
    static void main66()
    {
        Console.WriteLine("Реализовать собственную функцию сравнения строк (аналог strcmp) и функцию конкатенации строк без использования стандартных библиотечных функций.");
        string stroka1 =  "сиди";
        string stroka2 =  "дома";
        static int strcmp(string word1,string word2)
        {
            int minLen = word1.Length < word2.Length ? word1.Length : word2.Length;
            for(int i = 0; i < minLen; i++)
            {     
                if(word1[i]>word2[i]){Console.WriteLine("Левая строка больше правой");return 1;}
                else if(word1[i]<word2[i]){Console.WriteLine("Правая строка больше левой");return -1;}
            }
            if(word1.Length>word2.Length){Console.WriteLine("Левая строка больше правой");return 1;}
            else if(word1.Length<word2.Length){Console.WriteLine("Правая строка больше левой");return -1;}
            Console.WriteLine("Обе строки равны");
            return 0;
        }
        static string Concat(string word1,string word2)
        {

            char[] result = new char[word1.Length + word2.Length];
            for (int i = 0; i < word1.Length; i++) result[i] = word1[i];
            for (int i = 0; i < word2.Length; i++) result[word1.Length + i] = word2[i];
            return new string(result);
        }
        Console.WriteLine($"Итог strcmp: {strcmp(stroka1,stroka2)}");
        Console.WriteLine($"Итог конкатенации: {Concat(stroka1,stroka2)}");
    }
    static void main67()
    {
        Console.WriteLine("Реализовать собственную функцию сравнения строк (аналог strcmp) и функцию конкатенации строк без использования стандартных библиотечных функций.");
        string stroka =  "Люди сидят рядом, но каждый — в своём экране, и тишина между ними громче любого шума";
        static string CleanWord(string w)
        {
            char[] result = new char[w.Length];
            int k = 0;
            foreach (char c in w)
            {
                if (char.IsLetterOrDigit(c))
                result[k++] = c;
            }
            char[] trimmed = new char[k];
            for (int i = 0; i < k; i++)
                trimmed[i] = result[i];
            return new string(trimmed);
        }
        int indexrange =0;
        string[] words = stroka.Split(' ');
        for(int i = 0; i < words.Length; i++)
        {
            words[i] = CleanWord(words[i]);
            if(words[indexrange].Length<words[i].Length){indexrange =i;}
        }
        Console.WriteLine($"Самое длинное слово: {words[indexrange]}");
        string userinput;
        while (true)
        {
            Console.Write("Введите строку: ");
            userinput = Console.ReadLine() ?? "";
            if (!string.IsNullOrEmpty(userinput))
            break;
            Console.WriteLine("Пустой ввод, попробуйте ещё раз.");
        }
        userinput = userinput.ToLower();
        char[] arr1= userinput.ToCharArray();
        Array.Sort(arr1);
        for(int j = 0; j < words.Length; j++)
        {
            words[j] = CleanWord(words[j]);
            string temp =words[j];
            words[j]=words[j].ToLower();
            char[] arr2= words[j].ToCharArray();
            Array.Sort(arr2);
            if(arr1.Length == arr2.Length){
                bool isAnagram = true;
                for (int i = 0; i < arr1.Length; i++){
                    if (arr1[i] != arr2[i])
                    { isAnagram = false; break; }
                }
                if (isAnagram) Console.WriteLine($"Анаграмма: {temp}");
            }
        }
    }
    static void main71()
    {
        Console.WriteLine($"Оформить в виде отдельных функций несколько задач из предыдущих лабораторных работ (факториал, проверка простоты числа, сумма цифр).");
        static int factorial(int a)
        {
            int fact=1;
            for(int i = 1; i <= a; i++)
            {
                fact*=i;
            }
            return fact;
        }
        static void proverkaprosrcislo(int a)
        {
			bool prostoe = true;
            if (a < 2) {Console.WriteLine($"Число {a} не простое");return;}
            for(int i = 2; i <= a; i++)
			{
				if(a%i==0&&a!=i){Console.WriteLine($"Число {a} не простое");prostoe = false;break;}
			}
			if(prostoe){Console.WriteLine($"Число {a} простое");}
        }
        static float summacislo(int a)
        {
        while (true) 
        {
            int b = 0, sum = 0;
            while (a != 0) {
                b = a % 10;
                sum += a % 10;
                a -= b;
                a /= 10;
            } 
            return sum;
        }
    }
        Console.WriteLine($"Факториал числа 5 = {factorial(5)}");
        proverkaprosrcislo(5);
        Console.WriteLine($"Сумма цифер 6772 = {summacislo(6772)}");
    }
    static void main72()
    {
        Console.WriteLine($"Реализовать вычисление факториала и N-го числа Фибоначчи рекурсивно; сравнить с итеративной версией по скорости при больших N.).");
        static long FactorialR(int n)
        {
            if (n < 0) throw new ArgumentException("Факториал отрицательного не определён");
            if (n == 0 || n == 1) return 1; 
            return n * FactorialR(n - 1);
        }
            static long FibR(int n)
        {
            if (n == 0) return 0;    
            if (n == 1) return 1;    
            return FibR(n - 1) + FibR(n - 2);
        }
        Console.WriteLine($"Рекурсивный факториал: {FactorialR(5)}");
        Console.WriteLine($"Рекурсивный число фибоначчи{FibR(5)}");
    }
    static void main73()
    {
        Console.WriteLine($"Реализовать рекурсивный алгоритм быстрого возведения числа в степень (за O(log N) умножений).");
        Console.WriteLine($"9^10 = {FastPow(9, 10)}");
        Console.WriteLine($"9^11 = {FastPow(9, 11)}");
        Console.WriteLine($"2^10 = {FastPow(2, 10)}");
        Console.WriteLine($"5^0  = {FastPow(5, 0)}");
        Console.WriteLine($"7^1  = {FastPow(7, 1)}");
        static long FastPow(long s, int n)
        {
            if (n < 0)
                throw new ArgumentException("Отрицательная степень не поддерживается");
            if (n == 0)
                return 1;                         // база: s^0 = 1
            long half = FastPow(s, n / 2);        // s^(n/2) — делим ПОПОЛАМ
            long result = half * half;             // (s^(n/2))²
            if (n % 2 == 1)                        // если n нечётное
                result *= s;                       // домножаем на s

            return result;
        }
    }
    static void main74()
    {
        Console.WriteLine($"Реализовать рекурсивную функцию перевода числа из десятичной системы счисления в произвольную (2–16).");
        Console.WriteLine(ToBase(255, 16));   // FF
        Console.WriteLine(ToBase(83, 8));     // 123
        Console.WriteLine(ToBase(11, 2));     // 1011
        Console.WriteLine(ToBase(0, 8));      // 0
        Console.WriteLine(ToBase(5, 8));      // 5
        Console.WriteLine(ToBase(47, 16));    // 2F
        static string ToBase(int n, int b)
        {
            if (b < 2 || b > 16)
                throw new ArgumentException("Основание должно быть 2..16");
            if (n < 0)
                throw new ArgumentException("Отрицательные не поддерживаются");
            return ToBaseRec(n, b);
        }
        static string ToBaseRec(int n, int b)
        {
            // База: число уже меньше основания — это одна цифра
            if (n < b)
                return DigitToChar(n).ToString();
            // Шаг: старшая часть + младшая цифра
            int rem = n % b;
            return ToBaseRec(n / b, b) + DigitToChar(rem);
        }
        static char DigitToChar(int d)
        {
            if (d >= 0 && d <= 9) return (char)('0' + d);   // 0..9
            return (char)('A' + d - 10);                     // 10..15 → A..F
        }
    }
    static void main75()
    {
        Console.WriteLine($"Реализовать рекурсивную функцию перевода числа из десятичной системы счисления в произвольную (2–16).");
        Console.WriteLine(ToBase(255, 16));   // FF
        Console.WriteLine(ToBase(83, 8));     // 123
        Console.WriteLine(ToBase(11, 2));     // 1011
        Console.WriteLine(ToBase(0, 8));      // 0
        Console.WriteLine(ToBase(5, 8));      // 5
        Console.WriteLine(ToBase(47, 16));    // 2F
        static string ToBase(int n, int b)
        {
            if (b < 2 || b > 16)
                throw new ArgumentException("Основание должно быть 2..16");
            if (n < 0)
                throw new ArgumentException("Отрицательные не поддерживаются");
            return ToBaseRec(n, b);
        }
        static string ToBaseRec(int n, int b)
        {
            // База: число уже меньше основания — это одна цифра
            if (n < b)
                return DigitToChar(n).ToString();
            // Шаг: старшая часть + младшая цифра
            int rem = n % b;
            return ToBaseRec(n / b, b) + DigitToChar(rem);
        }
        static char DigitToChar(int d)
        {
            if (d >= 0 && d <= 9) return (char)('0' + d);   // 0..9
            return (char)('A' + d - 10);                     // 10..15 → A..F
        }
    }
    static void main76()
    {
        Console.WriteLine("Реализовать рекурсивный алгоритм подсчёта количества способов разбить число N на слагаемые (разбиение числа).");
        int n = 5;
        Console.WriteLine($"p({n}) = {CountPartitions(n)}");
        static int CountPartitions(int n)
        {
            if (n < 0) throw new ArgumentException("N >= 0");
            if (n == 0) return 1;
            return Count(n, n);
        }
        static int Count(int n, int max)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;
            if (max == 0) return 0;
            return Count(n, max - 1) + Count(n - max, max);
        }
    }
    static void main81()
    {
        Console.WriteLine("Реализовать сортировку вставками и сортировку Шелла.");
        //сортировка вставками
        int[] a = {217,8,5981,24,31,29,7,80,54,12,427};
        for(int i = 1; i < a.Length; i++)
        {
            int comparasion;
            if (a[i - 1] > a[i])
            {
                comparasion=i-1;
                while (comparasion >=0&&a[i] < a[comparasion]){
                    comparasion--;
                }
                for(int j = i; j!=comparasion+1; j--)
                {
                    (a[j],a[j-1])=(a[j-1],a[j]);
                }
            }
        }
        Console.WriteLine("Массив после сортировки вставками: ");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
        //сортировка Шелла
        int[] b = {217,8,5981,24,31,29,7,80,54,12,427};
        int gap = b.Length/2;
        while(true)
        {  
            if(gap==1)
            {
                for(int i = 1; i < b.Length; i++)
                {
                    int key = b[i];
                    int j = i;
                    while (j > 0 && b[j-1] > key)
                    {
                        b[j] = b[j-1];
                        j--;
                    }
                    b[j] = key;
                }
                break;
            }
            else
            {
                int i = 0;
                for(;i+gap < b.Length; i++)
                {
                    if (b[i] > b[i+gap])
                    {
                        (b[i],b[gap+i])=(b[gap+i],b[i]);
                    }
                }
                if (b[0] > b[gap])
                {
                    (b[0],b[gap])=(b[gap],b[0]);
                }
            }
            gap /=2;
        }
        Console.WriteLine("Массив после сортировки Шелла: ");
        for(int i = 0; i < b.Length; i++)
        {
            Console.Write($"{b[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static void main82()
    {
        // 1. Разбиение: возвращает индекс pivot после перестановки
        int[] a = {217,8,5981,24,31,29,7,80,54,12,427};
        static int Partition(int[] a, int left, int right)
        {
            int pivot = a[right];       // опорный — последний
            int i = left - 1;           // граница «меньших»

            for (int j = left; j < right; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    (a[i], a[j]) = (a[j], a[i]);   // своп через кортеж
                }
            }
            (a[i + 1], a[right]) = (a[right], a[i + 1]);   // pivot на место
            return i + 1;
        }
        // 2. Рекурсивная сортировка
        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)                       // база: 0 или 1 элемент — уже отсортирован
            {
                int p = Partition(a, left, right);  // pivot встал на место
                QuickSort(a, left, p - 1);          // левая часть
                QuickSort(a, p + 1, right);         // правая часть
            }
        }
        QuickSort(a, 0, a.Length - 1);
        Console.WriteLine("Массив после быстрой сортировки: ");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static void main83()
    {
        int[] a = {217,8,5981,24,31,29,7,80,54,12,427};
        static void Merge(int[] a, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++) L[i] = a[left + i];
            for (int j = 0; j < n2; j++) R[j] = a[mid + 1 + j];

            int x = 0, y = 0, k = left;

            while (x < n1 && y < n2)
            {
                if (L[x] <= R[y]) a[k++] = L[x++];
                else               a[k++] = R[y++];
            }
            while (x < n1) a[k++] = L[x++];
            while (y < n2) a[k++] = R[y++];
        }
        // 2. Рекурсивная сортировка
        static void MergeSort(int[] a, int left, int right)
        {
            if (left < right)                       // база: 0 или 1 элемент
            {
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);            // левая половина
                MergeSort(a, mid + 1, right);       // правая половина
                Merge(a, left, mid, right);         // слияние
            }
        }
        MergeSort(a, 0, a.Length - 1);
        Console.WriteLine("Массив после сортировки слиянием: ");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static void main84()
    {
       
            int[] sizes = {217,8,5981,24,31,29,7,80,54,12,427};
            string[] types = { "Случайный", "Отсортированный", "Обратный" };

            Console.WriteLine("Замеры времени сортировок (мс)\n");

            foreach (string type in types)
            {
                Console.WriteLine($"=== Тип массива: {type} ===");
                Console.WriteLine($"{"N",-8}{"Пузырёк",-12}{"Выбор",-12}{"Вставки",-12}{"Шелл",-12}{"Быстрая",-12}{"Слияние",-12}");

                foreach (int n in sizes)
                {
                    int[] original = MakeArray(n, type);

                    double t1 = Measure(BubbleSort,    (int[])original.Clone());
                    double t2 = Measure(SelectionSort, (int[])original.Clone());
                    double t3 = Measure(InsertionSort, (int[])original.Clone());
                    double t4 = Measure(ShellSort,     (int[])original.Clone());
                    double t5 = Measure(a => QuickSort(a, 0, a.Length - 1), (int[])original.Clone());
                    double t6 = Measure(a => MergeSort(a, 0, a.Length - 1), (int[])original.Clone());

                    Console.WriteLine($"{n,-8}{t1,-12:F3}{t2,-12:F3}{t3,-12:F3}{t4,-12:F3}{t5,-12:F3}{t6,-12:F3}");
                }
                Console.WriteLine();
            }
            static int[] MakeArray(int n, string type)
            {
                int[] a = new int[n];
                Random rnd = new Random(42);
                for (int i = 0; i < n; i++) a[i] = rnd.Next(0, n);

                if (type == "Отсортированный") Array.Sort(a);
                else if (type == "Обратный")   Array.Reverse(a);

                return a;
            }
            static double Measure(Action<int[]> sort, int[] a)
            {
                var sw = Stopwatch.StartNew();
                sort(a);
                sw.Stop();
                return sw.Elapsed.TotalMilliseconds;   // ← double, дробные мс
            }

            // --- сортировки (без изменений) ---
            static void BubbleSort(int[] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    bool swapped = false;
                    for (int j = 0; j < a.Length - 1 - i; j++)
                        if (a[j] > a[j + 1]) { (a[j], a[j + 1]) = (a[j + 1], a[j]); swapped = true; }
                    if (!swapped) break;
                }
            }

            static void SelectionSort(int[] a)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    int minIdx = i;
                    for (int j = i + 1; j < a.Length; j++)
                        if (a[j] < a[minIdx]) minIdx = j;
                    if (minIdx != i) (a[i], a[minIdx]) = (a[minIdx], a[i]);
                }
            }

            static void InsertionSort(int[] a)
            {
                for (int i = 1; i < a.Length; i++)
                {
                    int key = a[i], j = i;
                    while (j > 0 && a[j - 1] > key) { a[j] = a[j - 1]; j--; }
                    a[j] = key;
                }
            }

            static void ShellSort(int[] a)
            {
                for (int gap = a.Length / 2; gap > 0; gap /= 2)
                    for (int i = gap; i < a.Length; i++)
                    {
                        int key = a[i], j = i;
                        while (j >= gap && a[j - gap] > key) { a[j] = a[j - gap]; j -= gap; }
                        a[j] = key;
                    }
            }

            static void QuickSort(int[] a, int left, int right)
            {
                if (left >= right) return;
                int pivot = a[right], i = left - 1;
                for (int j = left; j < right; j++)
                    if (a[j] <= pivot) { i++; (a[i], a[j]) = (a[j], a[i]); }
                (a[i + 1], a[right]) = (a[right], a[i + 1]);

                QuickSort(a, left, i);
                QuickSort(a, i + 2, right);
            }

            static void MergeSort(int[] a, int left, int right)
            {
                if (left >= right) return;
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                Merge(a, left, mid, right);
            }

            static void Merge(int[] a, int left, int mid, int right)
            {
                int n1 = mid - left + 1, n2 = right - mid;
                int[] L = new int[n1], R = new int[n2];
                for (int i = 0; i < n1; i++) L[i] = a[left + i];
                for (int i = 0; i < n2; i++) R[i] = a[mid + 1 + i];

                int x = 0, y = 0, k = left;
                while (x < n1 && y < n2)
                    a[k++] = (L[x] <= R[y]) ? L[x++] : R[y++];
                while (x < n1) a[k++] = L[x++];
                while (y < n2) a[k++] = R[y++];
            }
        
    }
    
    static void main85()
    {
        
    }
    static void main86()
    {
        
    }
}