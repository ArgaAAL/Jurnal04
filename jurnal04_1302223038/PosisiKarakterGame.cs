using System;
//1302223038 MOD 3 = 2
class PosisiKarakterGame
{
    private string state = "Berdiri";

    public void ChangeState(string newState)
    {
        if (state == "Berdiri")
        {
            if (newState == "TombolS") {
                Console.WriteLine("Jongkok");
                state = "Jongkok";
            }
            else if (newState == "TombolW")
            {
                Console.WriteLine("posisi take off");
                Console.WriteLine("Terbang");
                state = "Terbang";
            }

        }
        else if (state == "Jongkok")
        {
            if (newState == "TombolS")
            {
                Console.WriteLine("Tengkurap");
                state = "Tengkurap";
            }
            else if (newState == "TombolW")
            {
                Console.WriteLine("Berdiri");
                state = "Berdiri";
            }
        }
        else if (state == "Terbang")
        {
            if (newState == "TombolS")
            {
                Console.WriteLine("Berdiri");
                state = "Berdiri";
            }
            else if (newState == "TombolX")
            {
                Console.WriteLine("Posisi landing");
                Console.WriteLine("Jongkok");
                state = "Jongkok";
            }
        }
        else if (state == "Tengkurap")
        {
            if (newState == "TombolW")
            {
                Console.WriteLine("Jongkok");
                state = "Jongkok";
            }
        }
        else
        {
            Console.WriteLine("Perintah tidak valid");
            return;
        }
        
    }
}