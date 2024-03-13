using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //No 1
        KodeBuah buah = new KodeBuah();
        Console.Write("Masukan buah pilihan: ");
        string pilihan = Console.ReadLine();
        Console.WriteLine(buah.getKodeBuah(pilihan));

        //No 2
        PosisiKarakterGame game = new PosisiKarakterGame();
        Console.WriteLine("\nState Awal: Berdiri");
        string perintah = "TombolS";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);
        

        perintah = "TombolS";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

        perintah = "TombolW";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

        perintah = "TombolW";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

        perintah = "TombolW";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

        perintah = "TombolW";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

        perintah = "TombolX";
        Console.WriteLine(perintah);
        Console.Write("State: ");
        game.ChangeState(perintah);

    }
}

