using arregloColas;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Colas cola = new Colas(5);

                cola.Agregar("A");
                cola.Agregar("B");
                cola.Agregar("C");

                Console.WriteLine(cola.ObtenerDatos());

                cola.Agregar("D");
                cola.Agregar("E");
                Console.WriteLine(cola.ObtenerDatos());

                cola.Agregar("F");
                Console.WriteLine(cola.ObtenerDatos());
                Console.WriteLine("Agregando D");
                Console.WriteLine(cola.ObtenerDatos());
                Console.WriteLine("Eliminando A");
                cola.Eliminar();
                Console.WriteLine(cola.ObtenerDatos());
                Console.WriteLine("Eliminando B");
                cola.Eliminar();
                Console.WriteLine(cola.ObtenerDatos());

                //Agregando problemas
                //cola.Agregar("");
                Console.WriteLine("Eliminando Todo");
                cola.Eliminar();
                cola.Eliminar();
                Console.WriteLine(cola.ObtenerDatos());
                cola.Eliminar();
                Console.WriteLine(cola.ObtenerDatos());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         }
    }
}
