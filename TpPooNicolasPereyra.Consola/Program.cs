using System.ComponentModel.DataAnnotations;
using System.Drawing;
using TpPooNicolasPereyra.Entidades;
using Utilidades;

namespace TpPooNicolasPereyra.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Piramides");

            var lado = ExtensionesConsola.PedirEntero("Ingrese el valor del lado de la base de la pirámide:");
            var altura = ExtensionesConsola.PedirEntero("Ingrese el valor de la altura de la pirámide:");

            PiramideCuadrada r = new PiramideCuadrada(lado, altura);

            var context = new ValidationContext(r);
            var errors = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(r, context, errors, true);
            if (isValid)
            {
                Console.WriteLine(r);
            }
            else
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
