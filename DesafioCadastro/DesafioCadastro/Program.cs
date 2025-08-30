using System.Globalization;
using DesafioCadastro.Entities;
using DesafioCadastro.Service;

namespace DesafioCadastro;

public class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        CarService carService = new CarService();
        
        Console.Write("Quantos carros voce quer cadastrar? ");
        int n = int.Parse(Console.ReadLine()!);


        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o nome do carro: ");
            string? carName = Console.ReadLine();
            

            Console.Write("Digite o preço do carro: $ ");
            double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            cars.Add(new Car(carName, price));

            Console.WriteLine();
        }
        
        carService.FindCheapest(cars);
    }
}