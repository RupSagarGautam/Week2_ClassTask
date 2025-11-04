
class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2002, 8, 12); 
        DateTime currentDate = DateTime.Now;
        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.Days / 365.25);

        Console.WriteLine("=== Date and Age Calculation ===");
        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {ageInYears} years");


        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine($"\nBirthdate + 10 days: {newDate.ToShortDateString()}");
    }
}