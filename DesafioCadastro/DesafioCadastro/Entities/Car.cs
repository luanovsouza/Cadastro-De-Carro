namespace DesafioCadastro.Entities;

public class Car
{
    public string? Name { get; set; }
    public double Price { get; set; }


    public Car(string? name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Car Name: {Name}, Price $ {Price.ToString("F2")}";
    }
}