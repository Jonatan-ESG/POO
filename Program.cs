namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro firulais = new Perro();

            firulais.saludar();



            Console.WriteLine(firulais.nombre);
            Console.WriteLine($"RAZA:{firulais.raza}");
               
            Perro max = new Perro("Max");
            Console.WriteLine(max.nombre);
        }
    }
}
    