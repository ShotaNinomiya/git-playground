using App.Logic;
using App.Model;

namespace UnitTest.Logic;

public class HouseGeneratorTest
{
    [Fact]
    public void CheckGeneratedData()
    {
        var list = HouseGenerator.GetHouse();
        list.Count.Is(11);
        list[0].Is(House.GetHeader());
        foreach (var i in Enumerable.Range(0,10))
        {
            var num = i + 2000;
            House h = new (num,$"test{num}");
            var expectedValue = h.ToString();
            list[i+1].Is(expectedValue);
        }
    }
}