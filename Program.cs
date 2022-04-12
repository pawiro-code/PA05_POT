using System;

/*
  program laduje do pamieci liczby a,b. Nastepnie bierze ostatnia cyfre(jednosci) z liczby a a nastepnie poteguje rekurencyknie przez liczbe b.
Liczba b przyjmuje wartosci dla a = 2 {2,4,8,6) (potem sie powtarzaja) np. ostatnia cyfra 2^5 = 2^1 dlatego przeprowadzaone jest modulo 4 na potedze b
Dla kazdej cyfry od 1 do 9 jest przypisana odpowiednia potega b. Program obsluguje tez przypadki graniczne jak 0^1 czy 1^500

 * */
class Program
{
    //int[] tab;
    public static long Potega(int a, int b)
    {
        long wynik = 1;

        for(int i = 0; i < b; i++)
        {
            wynik *= a;
        }
        return wynik;
    }

        
    public static int PotegaRekurencyjnie(int a, int b)
    {
        if(b == 0)
        {
            return 1;
        }
        if(b == 1)
        {
            return a;
        }
        if(a == 1)
        {
            return a;
        }
            
        int wynik = a*PotegaRekurencyjnie(a,b-1);
        return wynik;
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] tab = new string[n];
        for (int i = 0; i < n; i++)
        {
            //wczytanie calej lini i podzielenia liczb na komorki tablicy liczba
            string[] liczba = Console.ReadLine().Split();
            long x = long.Parse(liczba[0]);
            
            //ostatnia liczba liczby potegowej
            int a = liczba[0][liczba[0].Length - 1] - '0';
            //int b = int.Parse(liczba[1]);
            //ostatnia cyfra potegi
            int b = (liczba[1][liczba[1].Length - 1] - '0');
            //cala liczba potegi
            long y = long.Parse(liczba[1]);
           
            //przypadki graniczne
            if (y == 0)
            {
                tab[i] = Convert.ToString(1);
                
            }
            if (x == 10 || x == 100 || x == 1000 || x == 10000 || x == 100000 || x == 1000000 || x == 100000000 || x == 100000000 || x == 1000000000)
            {
                tab[i] = Convert.ToString(0);
            }


            //cyfry od 0 do 9
            if (a == 0)
            {
                b = 1;
            }
            else if (a == 1)
            {
                b = 0;
            }
            else if (a == 2)
            {
                if (y % 4 == 0)
                    b = 4;
                else if (y % 4 == 1)
                    b = 5;
                else if (y % 4 == 2)
                    b = 6;
                else if (y % 4 == 3)
                    b = 7;
            }
            else if (a == 3)
            {
                if (y % 4 == 0)
                    b = 4;
                else if (y % 4 == 1)
                    b = 5;
                else if (y % 4 == 2)
                    b = 6;
                else if (y % 4 == 3)
                    b = 7;
            }
            else if (a == 4)
            {
                if (y % 2 == 1)
                    b = 5;
                else
                    b = 6;
            }
            else if (a == 5)
            {
                b = 5;
            }
            else if (a == 6)
            {
                b = 6;
            }
            else if (a == 7)
            {
                if(y % 4 == 0)
                    b = 4;
                else if (y % 4 == 1)
                    b = 5;
                else if (y % 4 == 2)
                    b = 6;
                else if (y % 4 == 3)
                    b = 7;
            }
            else if (a == 8)
            {
                if (y % 2 == 1)
                    b += 4;
                else
                    b += 0;

            }
            else if (a == 9)
            {
                b += 0;
            }
            // long wynik = Potega(a, b);
            tab[i] = Convert.ToString(PotegaRekurencyjnie(a, b));
            //Console.WriteLine(wynik);
                
        }
        //wypisanie
        for(int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i][tab[i].Length-1] - '0');
        }
    }
 }

