using mApplication;

Console.WriteLine("Welcome to the myWater - which checks a resident's daily water consumption");
Console.WriteLine("**************************************************************************");
Console.WriteLine("");
Console.WriteLine("Enter the Inhabitent's name, surname and address:");
Console.ReadLine();

var inhabitant = new InhabitantInFile("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");

while (true)
{
    Console.WriteLine("Enter next measurement Inhabitant's:  ");
    var input = Console.ReadLine();
    if (input == "X" || input == "x")
    {
        break;
    }

    try
    {
        inhabitant.AddMeasurement(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

var statistics = inhabitant.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");