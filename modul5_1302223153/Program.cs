internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
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