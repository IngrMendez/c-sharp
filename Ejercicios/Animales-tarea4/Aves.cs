using System;

public abstract class Aves: Animal //
{
    public int CuantasPatas { get; set; }
 

    public void Volar() // 
    {
        Console.WriteLine("Volando...");
    }
}