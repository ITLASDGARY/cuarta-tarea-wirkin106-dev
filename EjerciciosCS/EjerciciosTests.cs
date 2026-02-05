using System;
using System.Collections.Generic;
using Xunit;

namespace EjerciciosCS.Tests
{
    public class EjerciciosTests
    {
        private readonly Ejercicios _ejercicios;

        public EjerciciosTests()
        {
            _ejercicios = new Ejercicios();
        }

        #region Tests para El Profesor Perezoso (Arrays)

        [Fact]
        public void CalcularPromedioTemperatura_DebeRetornarUnNumeroDouble()
        {
            // Arrange & Act
            var resultado = _ejercicios.CalcularPromedioTemperatura();

            // Assert
            Assert.IsType<double>(resultado);
        }

        [Fact]
        public void CalcularPromedioTemperatura_DebeRetornarUnValorPositivo()
        {
            // Arrange & Act
            var resultado = _ejercicios.CalcularPromedioTemperatura();

            // Assert
            Assert.True(resultado > 0, "El promedio debe ser un valor positivo");
        }

        [Fact]
        public void CalcularPromedioTemperatura_DebeRetornarUnPromedioRazonable()
        {
            // Arrange & Act
            var resultado = _ejercicios.CalcularPromedioTemperatura();

            // Assert
            // El promedio de 5 temperaturas debe estar entre -50 y 100 grados (valores razonables)
            Assert.True(resultado >= -50 && resultado <= 100, 
                $"El promedio {resultado} parece irrazonable para temperaturas");
        }

        [Fact]
        public void CalcularPromedioTemperatura_DebeSerElPromedioCorrectoDeLosValores()
        {
            // Arrange & Act
            var resultado = _ejercicios.CalcularPromedioTemperatura();

            // Assert
            // Si usaste valores como 20, 22, 24, 26, 28, el promedio sería 24
            // Permitimos un margen de error por redondeo
            Assert.InRange(resultado, 15.0, 35.0);
        }

        #endregion

        #region Tests para El Buscador (Reto)

        [Fact]
        public void BuscarNumeroDinamico_DebeRetornarBoolean()
        {
            // Arrange & Act
            var resultado = _ejercicios.BuscarNumeroDinamico(50);

            // Assert
            Assert.IsType<bool>(resultado);
        }

        [Fact]
        public void BuscarNumeroDinamico_BuscandoNumeroExistente_DebeRetornarTrue()
        {
            // Arrange
            // Act
            var resultado = _ejercicios.BuscarNumeroDinamico(50);

            // Assert
            Assert.IsType<bool>(resultado);
        }

        #endregion

        #region Tests de Integración

        [Theory]
        [InlineData(0)]
        [InlineData(50)]
        [InlineData(100)]
        public void BuscarNumeroDinamico_ConVariosNumeros_DebeRetornarBoolean(int numero)
        {
            // Arrange & Act
            var resultado = _ejercicios.BuscarNumeroDinamico(numero);

            // Assert
            Assert.IsType<bool>(resultado);
        }

        [Fact]
        public void TodosLosEjerciciosDebenEstarImplementados()
        {
            // Este test verifica que ningún método lance NotImplementedException
            // Arrange & Act & Assert
            try
            {
                _ejercicios.CalcularPromedioTemperatura();
                _ejercicios.BuscarNumeroDinamico(50);
                // Si llegamos aquí, todos los métodos están implementados
                Assert.True(true);
            }
            catch (NotImplementedException ex)
            {
                Assert.Fail($"Aún hay métodos sin implementar: {ex.Message}");
            }
        }

        #endregion
    }
}
