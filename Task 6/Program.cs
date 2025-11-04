// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Apple");
        Console.WriteLine("List of Fruits");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Orange" }
        };
        fruitDictionary.Add(4, "Grapes");

        Console.WriteLine("\n Fruit Dictionary");
        foreach (KeyValuePair<int, string> entry in fruitDictionary)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }
    }
}