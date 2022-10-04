using App.Logic;
using App.Model;

namespace UnitTest.Logic;

public class CarsGeneratorTest
{
    [Fact]
    public void CheckGeneratedData()
    {
        var list = CarsGenerator.GetCars();
        list.Count.Is(11);
        list[0].Is(Car.GetHeader());
        foreach (var i in Enumerable.Range(0, 10))
        {
            var num = i +1000;
            Car c = new(num, $"car{num}", 1000);
            var expectedValue = c.ToString();
            list[i + 1].Is(expectedValue);
        }
    }
}