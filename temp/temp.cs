using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;



    
using System.Threading;
 
// получаем текущий поток
Thread currentThread = Thread.CurrentThread;
 
//получаем имя потока
Console.WriteLine($"Имя потока: {currentThread.Name}");
currentThread.Name = "Метод Main";
Console.WriteLine($"Имя потока: {currentThread.Name}");
 
Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
Console.WriteLine($"Статус потока: {currentThread.ThreadState}");



/*char c = 'а'; 5⁵=5*5*5*5*5=3125
const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
char.IsDigit(c);        // true для '0'..'9' (и для цифр других письменностей, см. ниже)
char.IsLetter(c);       // true для любой буквы Unicode
char.IsLetterOrDigit(c); // true для буквы или цифры
char.IsWhiteSpace(c);   // true для пробела, \t, \n и т.д.
char.IsPunctuation(c);  // true для ., , ! ? и т.п. */ 