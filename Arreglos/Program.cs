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

                //Console.WriteLine(cola.ObtenerDatos());

                //cola.Agregar("D");
                //Console.WriteLine("Agregando D");
                //Console.WriteLine(cola.ObtenerDatos());
                //Console.WriteLine("Eliminando D");
                //cola.Eliminar();
                //Console.WriteLine(cola.ObtenerDatos());
                //Console.WriteLine("Eliminando C");
                //cola.Eliminar();

                ////Agregando problemas
                ////cola.Agregar("");
                //cola.Eliminar();
                //cola.Eliminar();
                //cola.Eliminar();
                //Console.WriteLine(cola.ObtenerDatos());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
