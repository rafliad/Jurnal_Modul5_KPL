internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        //NIM = 1302223153
        penjumlahan.JumlahTigaAngka<double>(13, 02, 22);
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
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

public class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;
    public SimpleDataBase()
    {
       this.storedData = new List<T>();
       this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int loop = 1;
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + loop + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            loop++;
        }
    }
}