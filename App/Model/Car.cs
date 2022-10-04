namespace App.Model;

public class Car
{
    // NOTE: 車のIDは1000以上とする。
    public int Id { get; set; }
    public string Name { get; set; }
    public double Plice { get; set; }

    public Car(int id, string name, double plice)
    {
        if(id < 1000) throw new ArgumentException();
        if(string.IsNullOrEmpty(name)) throw new ArgumentException();
        if(plice < 0) throw new ArgumentException();

        Id = id;
        Name = name;
        Plice = plice;
    }

    public override string ToString()
    {
        return $"{Id},{Name}";
    }

    public static string GetHeader()
    {
        return $"{nameof(Car.Id)},{nameof(Car.Name)}";
    }
}