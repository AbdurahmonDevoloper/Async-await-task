using System;
using System.Threading.Tasks;

class Task4
{
    public static async Task RunAsync()
    {
        Console.WriteLine("=== TASK 4: Fastest Delivery ===");
        Task<string> car = DeliveryByCar(); 
        Task<string> bike = DeliveryByBike(); 
        Task<string> drone = DeliveryByDrone();

        Task<string> fastestTask = await Task.WhenAny(car, bike, drone);
        Console.WriteLine($"\nFastest: {await fastestTask}");
        await Task.WhenAll(car, bike, drone);
    }

    static async Task<string> DeliveryByCar() { await Task.Delay(4000); return "Car"; }
    static async Task<string> DeliveryByBike() { await Task.Delay(5000); return "Bike"; }
    static async Task<string> DeliveryByDrone() { await Task.Delay(2000); return "Drone"; }
}