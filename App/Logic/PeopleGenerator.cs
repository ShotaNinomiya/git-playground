using App.Model;

namespace App.Logic;

public static class PeopleGenerator
{
    public static List<string> GetPeople()
    {
        List<string> result = new();
        IEnumerable<Person> people = Enumerable.Range(0,10).Select(x=>new Person(x,$"test{x}"));
        
        result.Add(Person.GetHeader());
        foreach (var p in people)
        {
            result.Add(p.ToString());
        }
        return result;
    }
}