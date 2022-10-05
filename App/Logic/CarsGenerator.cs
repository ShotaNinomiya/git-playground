using App.Model;

namespace App.Logic;

public class CarsGenerator
{
    public static List<string> GetCars()
    {
        List<string> result = new();
        IEnumerable<Car> cars = Enumerable.Range(1000, 10).Select(x => new Car(x, $"car{x}", 1000));

        result.Add(Car.GetHeader());
        foreach (var p in cars)
        {
            result.Add(p.ToString());
        }
        return result;
    }
}