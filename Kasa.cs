using System;

namespace Kasa
{
    static int UnBrArt()     //UnBrArt -> Unos Broja Artikala i kontrola unosa
    {
        int N;
        do
        {
            Console.Write("Molim vas unesite broj artikala koje ste kupili : ");
            try
            {
                N = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("GRESKA! Morate uneti broj!");
            }
        } while (true);
        return N;
    }

    static double Popust(int racun)      // Odredjivanje popusta 
    {
        if (racun <= 1000)
        {
            Console.WriteLine("Nadamo se da nismo preskupi! Na zalost niste ostvarili popust.");
            double popust = 0;
            return popust;
        }

        else
        {
            Console.WriteLine("Hvala vam na poverenju! Zasluili ste popust!");
            double popust = 0.10;

            return popust;
        }

    }

    static double NoviRacun(double popust, int racun)      //Iznos novog racuna ako je ostvaren popust 
    {

        double NovaCena = racun - popust;
        Console.WriteLine("Vas novi racun iznosi : " + NovaCena + " Dinara");
        Console.WriteLine("Ostvarili ste popust u vrednosti od " + popust + " dinara!");
        return NovaCena;
    }

    static void Main(string[] args)
    {

        int racun = 0;
        int BrArt = UnBrArt();
        Console.WriteLine("Broj artikala je : " + BrArt);

        int[] namirnica = new int[BrArt];

        for (int i = 0; i < BrArt; i++)                   // -----> Brojac 
        {

            Console.Write("Unesite cenu namirnice br. " + (i + 1) + " : ");
            namirnica[i] = Convert.ToInt32(Console.ReadLine());
            racun = racun + namirnica[i];

        }

        Console.WriteLine("Vas racun je  : " + racun + " dinara");

        double popust = (racun * Popust(racun));

        if (popust > 0)
            NoviRacun(popust, racun);

        else
            Console.WriteLine("Ukoliko niste znali, nudimo popuste na potrosnju vecu od 1000 dinara!");

    }
}
}



        }
