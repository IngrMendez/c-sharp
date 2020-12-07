public class Guacamaya: Aves
{
        public string Alimentacion { get; set; }
        public string Pico { get; set; }
        public string Genero { get; set; }

        public void Chillido()
        {
            Console.WriteLine(""guuua guuua);
        }
}
