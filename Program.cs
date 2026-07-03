using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("--- ASINXRON VAZIFALAR ISHGA TUSHDI ---\n");

        // Qaysi biri kerak bolsa shuni ochamiz 
        await Task1.RunAsync();
        // await Task2.RunAsync();
        // await Task3.RunAsync();
        // await Task4.RunAsync();
        // await Task5.RunAsync();
    }
}