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
    }
}




