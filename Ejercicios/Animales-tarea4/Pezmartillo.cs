using System;

public class PezEspada: Peces 
{
    public string Alimentacion { get; set; }
    public string Color { get; set; }

    public void ComeCarne()
    {
       Carnivoro();
    }
    private void Carnivoro() 
    {
        Console.WriteLine("Es carnivoro");
    }
}