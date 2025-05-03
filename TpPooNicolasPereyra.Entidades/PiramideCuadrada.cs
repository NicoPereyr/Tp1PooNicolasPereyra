
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TpPooNicolasPereyra.Entidades
{
    public class PiramideCuadrada:IValidatableObject
    {
        private int lado;
        private int altura;
        private double apotema;


        public PiramideCuadrada(int lado, int altura)
        {
            this.lado = lado;
            this.altura = altura;
            CalcularApotema();
        }

        private void CalcularApotema()
        {
            apotema = Math.Sqrt(Math.Pow(lado / 2.0, 2) + Math.Pow(altura, 2));
        }

        public double ObtenerApotema()
        {
            return apotema;
        }

        public double CalcularAreaBase()
        {
            return Math.Pow(lado, 2);
        }
        public double CalcularAreaLateral()
        {
            return 2 * lado * apotema;
        }
        public double CalcularAreaTotal()
        {
            return CalcularAreaBase() + CalcularAreaLateral();
        }
        public double CalcularVolumen()
        {
            return (Math.Pow(lado, 2) * altura) / 3.0;
        }
        public int Lado { get => lado;}
        public int Altura { get => altura;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Lado de la base: {lado}");
            sb.AppendLine($"Altura.............:{altura}");
            sb.AppendLine($"Volumen............:{CalcularVolumen():F2}");
            sb.AppendLine($"Area.............:{CalcularAreaTotal():F2}");
            sb.AppendLine($"Apotema..............:{apotema:F2}");
            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (lado <= 0)
            {
                yield return new ValidationResult("El lado de la base debe ser positiva");
            }
            if (altura <= 0)
            {
                yield return new ValidationResult("La altura debe ser positiva");
            }
        }

        public string MostrarDatos()
        {
            return $"Pirámide Cuadrada de Lado: {lado}, Altura: {altura}";
        }
    }

}
