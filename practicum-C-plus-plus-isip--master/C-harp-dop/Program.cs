using System;
using System.Diagnostics.CodeAnalysis;
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
            }
            else if (f == "8")
            {
                Console.WriteLine();
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
            }
            else if (f == "8")
            {
                Console.WriteLine();
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
            }
            else if (f == "7")
            {
                Console.WriteLine();
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
}