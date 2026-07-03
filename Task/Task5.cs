using System;
using System.Threading.Tasks;

class Task5
{
    public static async Task RunAsync()
    {
        Console.WriteLine("=== TASK 5: Online Shopping System ===");
        string userStatus = await ValidateUserAsync();
        
        Task<string> stockTask = CheckProductStockAsync(); 
        Task<string> discountTask = CalculateDiscountAsync(); 
        Task<string> shippingTask = CalculateShippingAsync();

        await Task.WhenAll(stockTask, discountTask, shippingTask);
        Console.WriteLine($"\nUser: {userStatus}\nStock: {stockTask.Result}\nDiscount: {discountTask.Result}\nShipping: {shippingTask.Result}\nOrder is ready!");
    }

    static async Task<string> ValidateUserAsync() { await Task.Delay(2000); return "Valid"; }
    static async Task<string> CheckProductStockAsync() { await Task.Delay(3000); return "Available"; }
    static async Task<string> CalculateDiscountAsync() { await Task.Delay(1500); return "15%"; }
    static async Task<string> CalculateShippingAsync() { await Task.Delay(2500); return "$5"; }
}