class myMotorcycle
{
    static void Main(string[] args)
    {
        Motorcycle myMotorcycle = new Motorcycle("Honda", "CBR500R", 2022, 471, "Red");
        myMotorcycle.Start();
        myMotorcycle.Accelerate();
        myMotorcycle.Brake();
        myMotorcycle.Stop();
    }
}
