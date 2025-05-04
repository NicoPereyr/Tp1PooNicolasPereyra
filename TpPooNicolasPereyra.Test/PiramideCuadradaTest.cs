using TpPooNicolasPereyra.Entidades;

namespace TpPooNicolasPereyra.Test
{
    [TestClass]
        public class PiramideCuadradaTest
        {
            [TestMethod]
            public void CalcularApotema_EsCorrecto()
            {
                // Arrange
                int lado = 6;
                int altura = 8;
                var piramide = new PiramideCuadrada(lado, altura);

                // Act
                double apotema = piramide.ObtenerApotema();

                // Assert
                double esperado = Math.Sqrt(Math.Pow(lado / 2.0, 2) + Math.Pow(altura, 2)); // ≈ 8.544
                Assert.AreEqual(esperado, apotema, 0.001);
            }

            [TestMethod]
            public void CalcularAreaBase_EsCorrecto()
            {
                // Arrange
                var piramide = new PiramideCuadrada(5, 10);

                // Act
                double areaBase = piramide.CalcularAreaBase();

                // Assert
                Assert.AreEqual(25, areaBase, 0.001);
            }

            [TestMethod]
            public void CalcularAreaLateral_EsCorrecto()
            {
                // Arrange
                int lado = 4;
                int altura = 3;
                var piramide = new PiramideCuadrada(lado, altura);

                // Act
                double areaLateral = piramide.CalcularAreaLateral();

                // Assert
                double apotema = Math.Sqrt(Math.Pow(lado / 2.0, 2) + Math.Pow(altura, 2)); // ≈ 3.6055
                double esperado = 2 * lado * apotema;
                Assert.AreEqual(esperado, areaLateral, 0.001);
            }

            [TestMethod]
            public void CalcularAreaTotal_EsCorrecto()
            {
                // Arrange
                var piramide = new PiramideCuadrada(6, 4);

                // Act
                double areaTotal = piramide.CalcularAreaTotal();

                // Assert
                double baseArea = Math.Pow(6, 2); // 36
                double apotema = Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2)); // 5
                double lateral = 2 * 6 * apotema; // 60
                double esperado = baseArea + lateral; // 96
                Assert.AreEqual(esperado, areaTotal, 0.001);
            }

            [TestMethod]
            public void CalcularVolumen_EsCorrecto()
            {
                // Arrange
                var piramide = new PiramideCuadrada(9, 6);

                // Act
                double volumen = piramide.CalcularVolumen();

                // Assert
                double esperado = (Math.Pow(9, 2) * 6) / 3.0; // 162
                Assert.AreEqual(esperado, volumen, 0.001);
            }
        }
    }

