using System.IO.Pipelines;

Console.WriteLine("Реализовать собственную функцию сравнения строк (аналог strcmp) и функцию конкатенации строк без использования стандартных библиотечных функций.");
        string stroka1 =  "сиди";
        string stroka2 =  "дома";
        string stroka3;
        void strcmp(string word1,string word2)
        {
          if(word1.Length>word2.Length){Console.WriteLine("Левая строка больше правой");}
          else if (word1.Length<word2.Length){Console.WriteLine("Правая строка больше левой");}
          else {Console.WriteLine("Обе строки равны");}
          return;
        }
        strcmp(stroka1,stroka2);
        stroka3=stroka1+' '+stroka2;
        Console.WriteLine($"Итог конкатенации: {stroka3}");
    




/*char c = 'а';
const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
char.IsDigit(c);        // true для '0'..'9' (и для цифр других письменностей, см. ниже)
char.IsLetter(c);       // true для любой буквы Unicode
char.IsLetterOrDigit(c); // true для буквы или цифры
char.IsWhiteSpace(c);   // true для пробела, \t, \n и т.д.
char.IsPunctuation(c);  // true для ., , ! ? и т.п. */