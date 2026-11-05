using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

static double FasterStepenRec(int s,int n)
{
    if (n < 0) throw new ArgumentException("Факториал отрицательного не определён");
    if (n == 0) return 0;
    double result=0;
    result += FasterStepenRec(s,n - 1);
    double resultNODR=Math.Truncate(result);
    double drob = result-resultNODR;
    string drobi = drob.ToString("F2");
    return result;
}
Console.WriteLine(FasterStepenRec(8,4));
    


    
    static void Main()
    {
        Console.WriteLine(ToBase(255, 16));   // FF
        Console.WriteLine(ToBase(83, 8));     // 123
        Console.WriteLine(ToBase(11, 2));     // 1011
        Console.WriteLine(ToBase(0, 8));      // 0
        Console.WriteLine(ToBase(5, 8));      // 5
        Console.WriteLine(ToBase(47, 16));    // 2F
    }

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

        




/*char c = 'а'; 5⁵=5*5*5*5*5=3125
const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
char.IsDigit(c);        // true для '0'..'9' (и для цифр других письменностей, см. ниже)
char.IsLetter(c);       // true для любой буквы Unicode
char.IsLetterOrDigit(c); // true для буквы или цифры
char.IsWhiteSpace(c);   // true для пробела, \t, \n и т.д.
char.IsPunctuation(c);  // true для ., , ! ? и т.п. */ 