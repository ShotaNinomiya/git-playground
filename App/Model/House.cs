namespace App.Model;
public class House
{
    public int Id { get; set; }
    public string Name { get; set; }

    public House(int id, string name)
    {
        if(id < 2000) throw new ArgumentException();
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
        return $"{nameof(House.Id)},{nameof(House.Name)}";
    }

}