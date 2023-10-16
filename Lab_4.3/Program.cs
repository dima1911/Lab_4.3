using System;
using System.Collections.Generic;

// Клас "Дорога"
public class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes
    {
        get; set;
    }
    public int TrafficLevel { get; set; }

    public Road(double length, double width, int lanes, int trafficLevel)
    {
        Length = length;
        Width = width;
        Lanes = lanes;
        TrafficLevel = trafficLevel;
    }
}

// Клас "Транспортний засіб"
public class Vehicle : IDriveable
{
    public double Speed { get; set; }
    public double Size { get; set; }
    public string Type { get; set; }

    public Vehicle(double speed, double size, string type)
    {
        Speed = speed;
        Size = size;
        Type = type;
    }

    public void Move()
    {
        Console.WriteLine($"{Type} is moving.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} has stopped.");
    }
}

// Інтерфейс для транспортних засобів
public interface IDriveable
{
    void Move();
    void Stop();
}

// Клас для моделювання руху
public class TrafficSimulation
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<Road> roads = new List<Road>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void AddRoad(Road road)
    {
        roads.Add(road);
    }

    public void SimulateTraffic()
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"A {vehicle.Type} with speed {vehicle.Speed} is on the road.");
            vehicle.Move();
            vehicle.Stop();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TrafficSimulation simulation = new TrafficSimulation();

        Road highway = new Road(100, 3, 4, 3);
        Road cityRoad = new Road(10, 2, 2, 2);

        Vehicle car = new Vehicle(60, 2, "Car");
        Vehicle truck = new Vehicle(40, 4, "Truck");

        simulation.AddVehicle(car);
        simulation.AddVehicle(truck);
        simulation.AddRoad(highway);
        simulation.AddRoad(cityRoad);

        simulation.SimulateTraffic();

        Console.WriteLine("Traffic simulation completed.");
    }
}
