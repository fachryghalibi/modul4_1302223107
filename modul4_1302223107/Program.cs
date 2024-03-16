public class KodeBuah
{
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika,
        Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian
        , Anggur, Melon, Semangka
    }
    public static string GetKodeBuah(NamaBuah buah)
    {
        string[] FruitCode = {"A00", "B00", "C00", "D00", "E00", "F00",
        "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        return FruitCode[(int)buah];
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukan nama buah: ");
        string inputbuah = Console.ReadLine();

        KodeBuah.NamaBuah buah;
        if (Enum.TryParse(inputbuah, true, out buah))
        {
            string FruitCode = KodeBuah.GetKodeBuah(buah);
            Console.WriteLine("Kode Buah untuk buah " + inputbuah
                + " adalah " + FruitCode);
        }
        else
        {
            Console.WriteLine("buah tidak valid");
        }

        
        
            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.DisplayPosisition();
            posisi.ChangeState(PosisiKarakterGame.State.BERDIRI);
        
    }
}




public class PosisiKarakterGame
{
    public enum State { TENGKURAP, JONGKOK, BERDIRI, TERBANG }
    State state = State.BERDIRI;
    public void ChangeState(State newState)
    {
        state = newState;
        while (true)
        {
            string command = Console.ReadLine();

            switch (state)
            {
                case State.TENGKURAP:
                    if (command == "w")
                    {
                        state = State.JONGKOK;
                        Console.WriteLine("tombol arah atas ditekan");
                        DisplayPosisition();
                    }
                    break;
                case State.JONGKOK:
                    if (command == "s")
                    {
                        state = State.TENGKURAP;
                        Console.WriteLine("tombol arah bawah ditekan");
                        DisplayPosisition();
                    }
                    else if (command == "w")
                    {
                        state = State.BERDIRI;
                        Console.WriteLine("tombol arah atas ditekan");
                        DisplayPosisition();
                    }
                    break;
                case State.BERDIRI:
                    if (command == "w")
                    {
                        state = State.TERBANG;
                        Console.WriteLine("tombol arah atas ditekan");
                        DisplayPosisition();
                    }
                    else if (command == "s")
                    {
                        state = State.JONGKOK;
                        Console.WriteLine("tombol arah bawah ditekan");
                        DisplayPosisition();
                    }
                    break;
                case State.TERBANG:
                    if (command == "x")
                    {
                        state = State.JONGKOK;
                        DisplayPosisition();
                    }
                    else if (command == "s")
                    {
                        state = State.BERDIRI;
                        Console.WriteLine("tombol arah bawah ditekan");
                        DisplayPosisition();
                    }
                    break;
            }
        }
    }

    public void DisplayPosisition()
    {
        Console.WriteLine("Posisi Sekarang: " + state);
    }
}

