using mApplication;

Console.WriteLine(" Welcome to the myWater - which checks a resident's daily water consumption");
Console.WriteLine("**************************************************************************");
Console.WriteLine("");
Console.WriteLine(" The measurement until is dm3 lub l(liter)");
Console.WriteLine(" In the application use shortened measurement values : A or a = 100, B or b = 200, C or c = 300, D or d = 400, E or e = 500, F or f = 600, G or g = 700, H or h = 800, I or i = 900, J or j = 1000");
Console.WriteLine(" When you want to finish,press X or x");
Console.WriteLine(" If the value we enter in the console is higher that 1100, the message will appear(Incorrect measurement value)");
Console.WriteLine(" If you enter a letter other that A-J and X, an error will be throw (Wrong Letter)");
var inhabitant = new InhabitantInMemory("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");

while (true)
{
    Console.WriteLine(" Enter next measurement Inhabitant's:  ");
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