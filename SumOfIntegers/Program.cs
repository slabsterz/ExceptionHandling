using System.Xml.Linq;

string[] input = Console.ReadLine().Split();

int sum  = 0;

for (int i = 0; i < input.Length; i++)
{
    string currentElement = input[i];

    try
    {
        int number = int.Parse(currentElement);
        sum += number;
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{currentElement}' is out of range!");
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{currentElement}' is in wrong format!");
    }
    finally
    {
        Console.WriteLine($"Element '{currentElement}' processed - current sum: {sum}");
    }
}
    Console.WriteLine($"The total sum of all integers is: {sum}");
