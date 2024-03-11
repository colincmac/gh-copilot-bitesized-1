using System.Diagnostics;


namespace DemoApp;
internal static class Helpers
{
    public static void CreateHotPath()
    {
        int percentage = 10;
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
            (new Thread(() =>
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                while (true)
                {
                    // Make the loop go on for "percentage" milliseconds then sleep the 
                    // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                    if (watch.ElapsedMilliseconds > percentage)
                    {
                        Thread.Sleep(100 - percentage);
                        watch.Reset();
                        watch.Start();
                    }
                }
            })).Start();
        }
    }

    public static void ConcatStrings()
    {
        string string1 = new("start");
        string string2 = new("appended");
        for (int i = 0; i < 20000; i++)
        {
            //string1 += strings[i];
            string1 = System.String.Concat(string1, string2);
        }
        Console.WriteLine(string1);
    }

    public static void DumpMemory()
    {
        var m = Environment.WorkingSet;
        Console.WriteLine($"Mem: {m:#,###}");
    }
}
