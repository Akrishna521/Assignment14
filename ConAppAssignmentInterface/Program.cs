using System;

interface IConnectable
{
    bool Connect();
}

interface IRechargeable
{
    void Charge(int minutes);
}

interface IDisplayable
{
    string Display();
}

class Smartphone : IConnectable, IRechargeable, IDisplayable
{

    public string Model { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public Smartphone(string model)
    {
        Model = model;
    }

    public bool Connect()
    {
        IsConnected = true;
        return IsConnected;
    }

    public void Charge(int minutes)
    {

        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"Smartphone {Model}: Battery Level - {BatteryLevel}%";
    }
}

class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public Laptop(string brand)
    {
        Brand = brand;
    }
    public bool Connect()
    {
        IsConnected = true;
        return IsConnected;
    }

    public void Charge(int minutes)
    {
        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"Laptop {Brand}: Battery Level - {BatteryLevel}%";
    }
}

class Program
{
    static void Main()
    {
        Smartphone smartphone = new Smartphone("iPhone");
        smartphone.Connect();
        smartphone.Charge(120);
        Console.WriteLine(smartphone.Display());

        Laptop laptop = new Laptop("Dell");
        laptop.Connect();
        laptop.Charge(90);
        Console.WriteLine(laptop.Display());
    }
}
