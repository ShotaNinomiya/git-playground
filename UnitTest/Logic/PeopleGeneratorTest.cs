using App.Logic;
using App.Model;

namespace UnitTest.Logic;

public class PeopleGeneratorTest
{
    [Fact]
    public void CheckGeneratedData()
    {
        var list = PeopleGenerator.GetPeople();
        list.Count.Is(11);
        list[0].Is(Person.GetHeader());
        foreach (var i in Enumerable.Range(0,10))
        {
            Person p = new (i,$"test{i}");
            var expectedValue = p.ToString();
            list[i+1].Is(expectedValue);
        }
    }
}