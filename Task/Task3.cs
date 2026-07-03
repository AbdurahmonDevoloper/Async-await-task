using System;
using System.Threading.Tasks;

class Task3
{
    public static async Task RunAsync()
    {
        Console.WriteLine("=== TASK 3: Student Information System ===");
        Task<string> nameTask = GetStudentNameAsync(); 
        Task<int> gradeTask = GetStudentGradeAsync(); 
        Task<string> attendanceTask = GetStudentAttendanceAsync();

        await Task.WhenAll(nameTask, gradeTask, attendanceTask);
        Console.WriteLine($"\nName: {nameTask.Result}\nGrade: {gradeTask.Result}\nAttendance: {attendanceTask.Result}");
    }

    static async Task<string> GetStudentNameAsync() { await Task.Delay(2000); return "Ali"; }
    static async Task<int> GetStudentGradeAsync() { await Task.Delay(3000); return 92; }
    static async Task<string> GetStudentAttendanceAsync() { await Task.Delay(2500); return "98%"; }
}