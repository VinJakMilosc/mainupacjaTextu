namespace mainupacjaTextu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napisz zdanie");
            string zdanie = Console.ReadLine();
            int dlugosc = zdanie.Length;
            string duzeZdanie = zdanie.ToUpper();
            string maleZdanie = zdanie.ToLower();

            Console.WriteLine("Podaj wariant: ");
            Console.WriteLine("Ilość znaków(1)");
            Console.WriteLine("Duże litery(2)");
            Console.WriteLine("Małe litery(3)");
            string wariant = Console.ReadLine();

            if (wariant == "1")
            {
                Console.WriteLine("Liczba liter: " + dlugosc);
            }
            else if (wariant == "2")
            {
                Console.WriteLine("Duże litery: " + duzeZdanie);
            }
            else if (wariant == "3")
            {
                Console.WriteLine("małe litery: " + maleZdanie);
            }


            Console.WriteLine("");
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            string bezSpacji = tekst.Trim();
            int ilosc = tekst.Length;
            string poczatek = tekst.Substring(0, 1);
            string koniec = tekst.Substring(tekst.Length - 1, 1);

            Console.WriteLine(bezSpacji);
            Console.WriteLine(ilosc);
            Console.WriteLine(poczatek);
            Console.WriteLine(koniec);

            Console.WriteLine("");
            Console.WriteLine("Podaj wyraz");
            string wyraz = Console.ReadLine();
            Console.WriteLine("Podaj litere której mam szukać");
            char litera = Console.ReadKey().KeyChar;
            int licznik = 0;
            for (int i = 0; i < wyraz.Length; i++)
            {
                if (wyraz[i] == litera)
                {
                    licznik++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Liczba liter " + litera + "w wyrazie " + wyraz + " to: " + licznik);


            Console.WriteLine("");
            Console.WriteLine("Npiasz zdanie (min. 3 slowa)");
            string slowa = Console.ReadLine();
            Console.WriteLine("Podaj 1 znak");
            string znak1 = Console.ReadLine();
            //Console.WriteLine("Podaj 2 znak");
            //string znak2 = Console.ReadLine();
            string zastamp = slowa.Replace(" ", znak1);

            Console.WriteLine(zastamp);

            Console.WriteLine("");
            Console.WriteLine("wpisz text");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Wpisz słowo (lub zdania) a sprawdze czy topalindrom");
            string palindrom = Console.ReadLine();
            bool czyPalindrom = true;

            for (int i = (palindrom.Length - 1) / 2; i >= 0; i--)
            {
                if (palindrom[i] != palindrom[palindrom.Length - 1 - i])
                {
                    czyPalindrom = false;
                    break;
                }
            }

            if (czyPalindrom)
            {
                Console.WriteLine(palindrom + " jest palindromem");
            }
            else
            {
                Console.WriteLine("To nie bedzie palindrom");

            }
            Console.WriteLine();
            Console.WriteLine("Wpisz słowa a ja ci policze");
            string podaneSlowa = Console.ReadLine();
            string[] ileSlowa = podaneSlowa.Split(" ");

            


            Console.WriteLine();
            Console.WriteLine("ilośc słów to: " + ileSlowa.Length);

        }
    }
}