class Program
{
    public static void Main()
    {
        Console.WriteLine("=== SISTEM KREDIT IMS FINANCE ===\n");

        // data
        decimal hargaMobil = 240000000m;
        decimal dpPersen = 0.20m;
        double jangkaWaktuTahun = 1.5;

        // dp dan pokok hutang
        decimal dp = hargaMobil * dpPersen;
        decimal pokokUtang = hargaMobil - dp;
        int jangkaWaktuBulan = (int)(jangkaWaktuTahun * 12);

        // bunga berdasarkan jangka waktu
        decimal bungaTahunan = 0;
        if (jangkaWaktuBulan > 12 && jangkaWaktuBulan <= 24)
        {
            bungaTahunan = 0.14m; // bunga 14%
        }
        else if (jangkaWaktuBulan <= 12)
        {
            bungaTahunan = 0.12m;
        }
        else
        {
            bungaTahunan = 0.165m;
        }

        // angsuran perbulan
        // (pokok utang + (pokok utang * bunga)) / jangka waktu
        decimal totalBunga = pokokUtang * bungaTahunan;
        decimal angsuranPerBulan = (pokokUtang + totalBunga) / jangkaWaktuBulan;

        // hasil
        Console.WriteLine($"--- Perhitungan Angsuran Pak Sugus ---");
        Console.WriteLine($"Harga Mobil      : {hargaMobil:N0}");
        Console.WriteLine($"DP (20%)         : {dp:N0}");
        Console.WriteLine($"Pokok Utang      : {pokokUtang:N0}");
        Console.WriteLine($"Jangka Waktu     : {jangkaWaktuBulan} bulan");
        Console.WriteLine($"Bunga per Tahun  : {bungaTahunan:P0}");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Angsuran per Bulan : Rp {angsuranPerBulan:N0}");
    }
}