using System;

public class Motorcycle
{
    public string Make { get; set; }       
    public string Model { get; set; }    
    public int Year { get; set; }          
    public double EngineSize { get; set; } 
    public string Color { get; set; }     

    
    public Motorcycle(string make, string model, int year, double engineSize, string color)
    {
        Make = make;
        Model = model;
        Year = year;
        EngineSize = engineSize;
        Color = color;
    }

    public void Start()
    {
        Console.WriteLine($"Запуск мотоцикла {Make} {Model}.");
    }

   
    public void Stop()
    {
        Console.WriteLine($"Остановка мотоцикла {Make} {Model}.");
    }

   
    public void Accelerate()
    {
        Console.WriteLine($"Мотоцикл {Make} {Model} ускоряется.");
    }

    public void Brake()
    {
        Console.WriteLine($"Мотоцикл {Make} {Model} тормозит.");
    }
}
