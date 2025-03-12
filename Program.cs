//SOAL 1

using System;
using System.Collections.Generic;

/*class kodeProduk
{
    private Dictionary<String, String> kodeProdukTable = new Dictionary<string, string>
    {
        { "Laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" },
        { "Mouse", "E105" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "Smartwatch", "E108" },
        { "Kamera", "E109" },
    };

    public String GetKodeProduk(String produk)
    {
        if (kodeProdukTable.ContainsKey(produk))
        {
            return kodeProdukTable[produk];
        }
        else
        {
            return "Kode Produk Tidak Di Temukan";
        }
    }
}

class Program
{
    static void Main()
    {
        kodeProduk kodeProduk = new kodeProduk();

        Console.Write("Masukan Nama Produk : ");
        string produk = Console.ReadLine();

        String kode = kodeProduk.GetKodeProduk(produk);
        Console.WriteLine($"Kode Produk Untuk {produk} adalah {kode}");
    }
}*/

//SOAL 2

public enum fanLaptopState
{
    Quiet,
    Balanced,
    Performance,
    Turbo
}

public class fanLaptop
{

    private fanLaptopState state;

    public void QuietTurbo()
    {
        if (state == fanLaptopState.Quiet)
        {
            state = fanLaptopState.Turbo;
            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
        }
        else
        {
            Console.WriteLine("Fan Quiet tidak berubah menjadi Turbo");
        }
    }

    public void QuietBalanced()
    {
        if (state == fanLaptopState.Quiet)
        {
            state = fanLaptopState.Balanced;
            Console.WriteLine("Fan Quiet tidak berubah menjadi Balanced");
        }
        else
        {
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }
    }
}

class Program
{
    static void Main()
    {
        fanLaptop fanLaptop = new fanLaptop();

        fanLaptop.QuietTurbo();
        fanLaptop.QuietBalanced();
    }
}