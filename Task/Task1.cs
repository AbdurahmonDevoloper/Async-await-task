using System;
using System.Threading.Tasks;

class Task1
{
    
    public static async Task RunAsync() 
    {
        Console.WriteLine("=== TASK 1: Breakfast Preparation ===");
        Task eggTask = BoilEgg(); 
        Task breadTask = ToastBread(); 
        Task teaTask = MakeTea();
        
        await Task.WhenAll(eggTask, breadTask, teaTask);
        Console.WriteLine("\nBreakfast is ready!");
    }

    static async Task BoilEgg() { Console.WriteLine("Tuxum qaynatilyapti..."); await Task.Delay(3000); }
    static async Task ToastBread() { Console.WriteLine("Non qizdirilyapti..."); await Task.Delay(2000); }
    static async Task MakeTea() { Console.WriteLine("Choy damlanyapti..."); await Task.Delay(4000); }
}