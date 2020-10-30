using System;
using System.Security;

public class Program
{
    public static void Main()
    {
    Start:
        int b;
        int h;
        int l1;
        int l2;
        int l3;

        Console.WriteLine("Scegli una figura: quadrato/rettangolo, triangolo:");
        string mainline = Console.ReadLine();
        if (mainline == "quadrato")
        {
            Console.WriteLine("Vuoi calcolare l'area o il perimetro? Scrivi area o perimetro: ");
            string line = Console.ReadLine();
            if (line == "area")
            {
                Console.WriteLine("Inserire la base: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire l'altezza: ");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine(b * h);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }
            else if (line == "perimetro")
            {
                Console.WriteLine("Inserisci la misura del lato 1: ");
                l1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine(l1 * 4);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }

            else
            {
                Console.Beep();
                Console.WriteLine("Operazione non valida! Controlla di aver scritto area o perimetro in minuscolo e senza errori ortografici. Premi invio per continuare...");
                Console.ReadKey();
                goto Start;
            }
        }
        else if (mainline == "rettangolo")
        {
            Console.WriteLine("Vuoi calcolare l'area o il perimetro? Scrivi area o perimetro: ");
            string line = Console.ReadLine();
            if (line == "area")
            {
                Console.WriteLine("Inserire la base: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire l'altezza: ");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine(b * h);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }
            else if (line == "perimetro")
            {
                Console.WriteLine("Inserisci la misura del lato 1: ");
                l1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la misura del lato 2: ");
                l2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine((l1 + l2) * 2);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }


        

        else
            {
                Console.Beep();
                Console.WriteLine("Operazione non valida! Controlla di aver scritto area o perimetro in minuscolo e senza errori ortografici. Premi invio per continuare...");
                Console.ReadKey();
                goto Start;
            }
        }

        else if (mainline == "triangolo")

        {
            Console.WriteLine("Vuoi calcolare l'area o il perimetro? Scrivi area o perimetro: ");
            string line = Console.ReadLine();
            if (line == "area")
            {
                Console.WriteLine("Inserire la base: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire l'altezza: ");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine((b * h) / 2);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }
            else if (line == "perimetro")
            {
                Console.WriteLine("Inserisci la misura del lato 1: ");
                l1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la misura del lato 2: ");
                l2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci la misura del lato 3: ");
                l3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Il risultato è: ");
                Console.WriteLine(l1 + l2 + l3);
                Console.WriteLine("Premi un tasto qualsiasi per uscire...");
                Console.ReadKey();
            }




            else
            {
                Console.Beep();
                Console.WriteLine("Operazione non valida! Controlla di aver scritto area o perimetro in minuscolo e senza errori ortografici. Premi invio per continuare...");
                Console.ReadKey();
                goto Start;
            }
        }

        else

        {
            Console.Beep();
            Console.WriteLine("Operazione non valida! Controlla di aver scritto quadrato, rettangolo o triangolo in minuscolo e senza errori ortografici. Premi invio per continuare...");
            Console.ReadKey();
            goto Start;
        }

            
        }

    }


