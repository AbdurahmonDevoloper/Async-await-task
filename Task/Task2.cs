using System;
using System.Threading.Tasks;

class Task2
{
    
    public static async Task RunAsync()
    {
        Console.WriteLine("=== TASK 2: Download Manager ===");
        Task d1 = DownloadFile1(); 
        Task d2 = DownloadFile2(); 
        Task d3 = DownloadFile3();

        await Task.WhenAll(d1, d2, d3);
        Console.WriteLine("\nAll files have been downloaded.");
    }

    static async Task DownloadFile1() { Console.WriteLine("File 1 yuklanyapti."); await Task.Delay(3000); }
    static async Task DownloadFile2() { Console.WriteLine("File 2 yuklanyapti."); await Task.Delay(5000); }
    static async Task DownloadFile3() { Console.WriteLine("File 3 yuklanyapti."); await Task.Delay(2000); }
}