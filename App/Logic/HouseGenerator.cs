using App.Model;

namespace App.Logic;

public static class HouseGenerator
{
    public static List<string> GetHouse()
    {
        List<string> result = new();
        IEnumerable<House> people = Enumerable.Range(2000,10).Select(x=>new House(x,$"test{x}"));
        
        result.Add(House.GetHeader());
        foreach (var p in people)
        {
            result.Add(p.ToString());
        }
        return result;
    }
}