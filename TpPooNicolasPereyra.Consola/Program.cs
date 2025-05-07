using System.ComponentModel.DataAnnotations;
using TpPooNicolasPereyra.Entidades;
using Utilidades;

namespace TpPooNicolasPereyra.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Piramides");

            int cantidadIngresos = 0;
            do
            {
                var lado = ExtensionesConsola.PedirEnteroPositivo("Ingrese el valor del lado de la base de la pirámide:");
                var altura = ExtensionesConsola.PedirEnteroPositivo("Ingrese el valor de la altura de la pirámide:");

                PiramideCuadrada p = new PiramideCuadrada(lado, altura);

                var context = new ValidationContext(p);
                var errors = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(p, context, errors, true);
                if (isValid)
                {
                    Console.WriteLine(p);
                    cantidadIngresos++;
                }
                else
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                } 
            } while (ExtensionesConsola.ConfirmarDatos("¿Desea ingresar otro juego de datos? (S/N): "));

            Console.WriteLine($"\nCantidad de pirámides ingresadas correctamente: {cantidadIngresos}");
        }
    }
}
