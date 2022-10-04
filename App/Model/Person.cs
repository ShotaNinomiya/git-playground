namespace App.Model;
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person(int id, string name)
    {
        if(id < 0) throw new ArgumentException();
        if(string.IsNullOrEmpty(name)) throw new ArgumentException();

        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Id},{Name}";
    }

    public static string GetHeader()
    {
        return $"{nameof(Person.Id)},{nameof(Person.Name)}";
    }

}