// See https://aka.ms/new-console-template for more information

using App.Logic;
foreach (var p in PeopleGenerator.GetPeople())
{
    Console.WriteLine(p);
}

foreach (var c in CarsGenerator.GetCars())
{
    Console.WriteLine(c);
}