using System.IO.Pipelines;

        static void proverkaprosrcislo(float a)
        {
			bool prostoe = true;
            for(int i = 1; i <= a; i++)
			{
				if(a%i!=0&&a!=i&&a!=1){Console.WriteLine($"Число {a} не простое");prostoe = false;break;}
			}
			if(prostoe){Console.WriteLine($"Число {a} простое");}
        }
        

        proverkaprosrcislo(5);



    
        




/*char c = 'а';
const string glasnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";
char.IsDigit(c);        // true для '0'..'9' (и для цифр других письменностей, см. ниже)
char.IsLetter(c);       // true для любой буквы Unicode
char.IsLetterOrDigit(c); // true для буквы или цифры
char.IsWhiteSpace(c);   // true для пробела, \t, \n и т.д.
char.IsPunctuation(c);  // true для ., , ! ? и т.п. */ 