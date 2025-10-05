class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEM KREDIT IMS FINANCE ===");

        // data kontrak
        string kontrakNo = "AGR00001";
        string client = "SUGUS";
        decimal otr = 240_000_000m;
        decimal dpPercentage = 20m;
        int tenorBulan = 18;
        DateTime tanggalKontrak = new DateTime(2023, 12, 25);

        // hitung dp dan pokok pinjaman
        decimal downPayment = otr * (dpPercentage / 100);
        decimal pokokPinjaman = otr - downPayment;

        // hitung bunga (asumsi flat 6% per tahun)
        decimal bungaTahunan = 6m;
        decimal totalBunga = pokokPinjaman * (bungaTahunan / 100) * (tenorBulan / 12m);

        decimal totalPembayaran = pokokPinjaman * totalBunga;
        decimal angsuranPerBulan = totalPembayaran / tenorBulan;

        Console.WriteLine("DETAIL KONTRAK:");
        Console.WriteLine($"Kontrak No: {kontrakNo}");
        Console.WriteLine($"Client: {client}");
        Console.WriteLine($"OTR (Harga Mobil): {otr:N0}");
        Console.WriteLine($"Down Payment (20%): {downPayment:N0}");
        Console.WriteLine($"Pokok Pinjaman: {pokokPinjaman:N0}");
        Console.WriteLine($"Bunga ({bungaTahunan}% per tahun): {totalBunga:N0}");
        Console.WriteLine($"Total Pembayaran: {totalPembayaran:N0}");
        Console.WriteLine($"Tenor: {tenorBulan} bulan");
        Console.WriteLine($"\nANGSURAN PER BULAN: Rp {angsuranPerBulan:N0}");

        Console.WriteLine($"\n {new string('=', 50)} \n");
    }

}
// model classes
public class JadwalAngsuran
{
    public string KontrakNo { get; set; } = string.Empty;
    public string Client { get; set; } = string.Empty;
    public int AngsuranKe { get; set; }
    public decimal AngsuranPerBulan { get; set; }
    public DateTime TanggalJatuhTempo { get; set; }
}

public class AngsuranJatuhTempo
{
    public decimal TotalAngsuran { get; set; }
    public int JumlahAngsuran { get; set; }
}

public class DendaKeterlambantan
{
    public string KontrakNo { get; set; } = string.Empty;
    public string Client { get; set; } = string.Empty;
    public int AngsuranKe { get; set; }
    public int HariKeterlambatan { get; set; }
    public decimal TotalDenda { get; set; }
}