// See https://aka.ms/new-console-template for more information
class Circle
{
    public const double PI = 3.14;
    static void Main(string[] args)
    {
        Circle.PI = 4.10;
        Console.WriteLine($"The value of PI is: {Circle.PI}");
    }
    public void calculateArea(double r)
    {
        double area = PI * r * r;
        Console.WriteLine($"The area of the circle is: {area}");
    }
    public void calculatePerimeter(double r)
    {
        double perimeter = 2 * PI * r;
        Console.WriteLine($"The perimeter of the circle is: {perimeter}");
        Console.ReadLine();
    }
    

}