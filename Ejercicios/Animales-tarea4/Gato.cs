using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsArisco { get; set; }

    public Gato() 
    {
        EsArisco = true;
    }
    public Gato (bool esArisco) 
    {
        EsArisco = esArisco;
    }
    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");

    }

}
