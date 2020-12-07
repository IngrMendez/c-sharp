using System;

public class Pinguino: Aves
{
    public string Incubacion { get; set; }

    public string Alimentacion { get; set; }

    public void graznido()
    {
        Console.WriteLine("A través de su graznido para reconocerse");
    }
}