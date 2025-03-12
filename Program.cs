//SOAL 1

using System;
using System.Collections.Generic;

class kodeProduk
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
}
