using DesafioCadastro.Entities;

namespace DesafioCadastro.Service;

public class CarService
{
    public void FindCheapest(List<Car> cars)
    {
        Car max = cars[0];

        foreach (Car car in cars)
        {
            if (car.Price < max.Price)
            {
                max = car;
            }
        }

        Console.WriteLine($"O carro mais barato é: {max}");
    }
}