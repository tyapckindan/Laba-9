class Car
{
    public string Name = string.Empty;

    public Car(string name)
    {
        Name = name;
    }
}

class Garage
{
    public List<Car> Cars = new();
    public List<Car> AddInfo(List<Car> cars, Car car)
    {
        cars.Add(car);
        return cars;
    }

    public List<Car> RemoveInfo(List<Car> cars, Car car)
    {
        cars.Remove(car);
        return cars;
    }

    public void WashAllCars(Washed del)
    {
        foreach (Car car in Cars)
        {
            del(car);
        }
    }
}

class Washer
{
    public void Wash(Car car) => Console.WriteLine($"Машина {car.Name} помыта.");
}
internal class Program
{
    private static void Main(string[] args)
    {   
        Garage garage = new();
        Washer washer = new();
        Car yaz = new("УаЗ");
        Car mazda = new("MaZda");

        Washed del = washer.Wash;

        garage.Cars = garage.AddInfo(garage.Cars, yaz);
        garage.Cars = garage.AddInfo(garage.Cars, mazda);

        garage.WashAllCars(del);
    }
}

delegate void Washed(Car car);