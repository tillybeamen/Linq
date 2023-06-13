using System;
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 IEnumerable<Eruption> firstChile = eruptions.Where(eruption => eruption.Location == "Chile").Take(1);
 PrintEach(firstChile);
 //First Hawaii
 IEnumerable<Eruption> firstHawaii = eruptions.Where(eruption => eruption.Location =="Hawaiian Is").Take(1);
 PrintEach(firstHawaii);
 //First Greenland
Eruption? greenland = eruptions.FirstOrDefault(eruption => eruption.Location == "Greenland");
if (greenland != null)
{
    System.Console.WriteLine(greenland.ToString());
}
else
{
    System.Console.WriteLine("None Available");
}
// New Zealand
IEnumerable<Eruption> newZealand = eruptions.Where(eruptions => eruptions.Location=="New Zealand").Where(eruptions => eruptions.Year >= 1900).Take(1);
PrintEach(newZealand);

// Elevation over 2000

IEnumerable<Eruption> elevation =eruptions.Where(eruptions => eruptions.ElevationInMeters >= 2000);
PrintEach(elevation);

// Print highest elevation
int elevationHigh = eruptions.Max(eruption => eruption.ElevationInMeters);
PrintEach(elevation);
System.Console.WriteLine(elevationHigh);

Eruption? highestEl = eruptions.FirstOrDefault(eruption => eruption.ElevationInMeters == elevationHigh);
System.Console.WriteLine(highestEl.Volcano);

//Eruptions that start with L and how many
IEnumerable<Eruption> startsWithL = eruptions.Where(eruption => eruption.Volcano.StartsWith("L"));
PrintEach(startsWithL);
System.Console.WriteLine("STARTS WITH L");
System.Console.WriteLine(startsWithL.Count());

// All Volcano names in alphabetical
IEnumerable<string> alpha = eruptions.Select(eruptions => eruptions.Volcano).OrderBy(eruptions => eruptions);
System.Console.WriteLine(String.Join(",",alpha));

//Sum of all elevations
int sum = eruptions.Sum(eruption => eruption.ElevationInMeters);
System.Console.WriteLine(sum);

//Any in year 2000

bool year = eruptions.Any(eruption=> eruption.Year == 2000);
System.Console.WriteLine(year);

// First 3 strato
IEnumerable<Eruption> stratoVolcanoEruptions = eruptions.Where(c=> c.Type == "Stratovolcano").Take(3);
PrintEach(stratoVolcanoEruptions, "Stratovolcano eruptions");

//Before year 1000
IEnumerable<string> alphabetically = eruptions.Where(eruptions => eruptions.Year <1000).Select(eruptions=> eruptions.Volcano).OrderBy(eruptions=> eruptions);
System.Console.WriteLine(String.Join(",", alphabetically));



// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
