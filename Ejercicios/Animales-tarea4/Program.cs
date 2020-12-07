using System;

namespace Animales_tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
           Perro p = new Perro();
            Console.WriteLine("|Perro|");
            Console.WriteLine("-------");
            p.Nombre = "Roki";
            p.CuantasPatas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Orden = "Carnivora";
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine("Nombre: " + p.Nombre);
            Console.WriteLine("Cuantas Patas: " + p.CuantasPatas);
            if (p.EsDomestico == true)
            {
                Console.WriteLine("Es domestico");
            }

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("|Gato|");
            Console.WriteLine("------");
            g.Nombre = "Michi";
            g.CuantasPatas = 4;
            g.Pelaje = "Pelo Corto";
            g.Raza = "Persa";
            g.Orden = "Carnivora";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsArisco = true;

            Console.WriteLine("Nombre: " + g.Nombre);
            Console.WriteLine("Cuantas Patas: " + g.CuantasPatas);
            Console.WriteLine("Tipo de pelaje: " + g.Pelaje);
            Console.WriteLine("Raza: " + g.Raza);

            Console.WriteLine();

            Nutria n = new Vaca();
            Console.WriteLine("|Vaca|");
            Console.WriteLine("--------");
            n.Nombre = "Lola";
            n.CuantasPatas = 4;
            n.Orden = "Herbiboros";
            n.EsSalvaje = true;
            n.Comer();
            n.Caminar();

            Console.WriteLine("Nombre: " + n.Nombre);
            Console.WriteLine("Cuantas Patas: " + n.CuantasPatas);
            Console.WriteLine("Orden: " + n.Orden);
            if (n.NoEsSalvaje == true)
            {
                Console.WriteLine("No es salvaje");
            }

            Console.WriteLine();

            Colibri c = new Guacamaya();
            Console.WriteLine("|Guacamaya|");
            Console.WriteLine("---------");
            c.Nombre = "Margi";
            c.CuantasPatas = 2;
            c.Pico = "Pico largo y afilado";
            c.Genero = "Ara";
            c.Orden = "Psittaciformes";
            c.Alimentacion = "se alimentan de nectare, plantas,semillas y frutas,.";
            c.Comer();
            c.Volar();
            c.Zumbido();

            Console.WriteLine("Nombre: " + c.Nombre);
            Console.WriteLine("Cuantas patas: " + c.CuantasPatas);
            Console.WriteLine("Tipo de pico: " + c.Pico);
            Console.WriteLine("Tipo de genero: " + c.Genero);
            Console.WriteLine("Tipo de Orden: " + c.Orden);
            Console.WriteLine("Alimentacion: " + c.Alimentacion);

            Console.WriteLine();

            Pinguino pi = new Pinguino();
            Console.WriteLine("|Pinguino|");
            Console.WriteLine("----------");
            pi.Nombre = "Bri";
            pi.CuantasPatas = 2;
            pi.Orden = "Sphenisciformes";
            pi.Alimentacion = "Se alimentan fundamentalmente de peces y otras serpientes";
            pi.Incubacion = "El periodo de incubación de 33 y 62 días según la especie";
            pi.graznido();
            pi.Comer();
            
            Console.WriteLine("Nombre: " + pi.Nombre);
            Console.WriteLine("Cuantas patas: " + pi.CuantasPatas);
            Console.WriteLine("Tipo de Orden: " + pi.Orden);
            Console.WriteLine("Alimentacion: " + pi.Alimentacion);
            Console.WriteLine("Periodo de incubacion: " + pi.Incubacion);

            Console.WriteLine();

            PezEspada pe = new PezMartillo();
            Console.WriteLine("|Pez Martillo|");
            Console.WriteLine("------------");
            pe.Nombre = "Red";
            pe.Aletas = 5;
            pe.Orden = "Carcharhiniformes";
            pe.Alimentacion = "Sealimentan de angilas,meros,pargos,rayas etc.";
            pe.Nadar();
            pe.ComeCarne(); 

            Console.WriteLine("Nombre: " + pe.Nombre);
            Console.WriteLine("Cuantas aletas: " + pe.Aletas);
            Console.WriteLine("Tipo de Orden: " + pe.Orden);
            Console.WriteLine("Alimentacion: " + pe.Alimentacion);

        }
    }
}