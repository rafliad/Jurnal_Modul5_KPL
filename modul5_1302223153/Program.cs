internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        //NIM = 1302223153
        penjumlahan.JumlahTigaAngka<double>(13, 02, 22);
    }
}

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic hasil;
        dynamic data1dyn = data1;
        dynamic data2dyn = data2;
        dynamic data3dyn = data3;
        hasil = data1dyn + data2dyn + data3dyn;
        Console.WriteLine(hasil);
    }
}