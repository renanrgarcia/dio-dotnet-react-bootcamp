using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidarStringsTests
    {
        private ValidarStrings _validarStrings;
        public ValidarStringsTests()
        {
            _validarStrings = new ValidarStrings();
        }

        [Fact]
        public void DeveRetornar11CaracteresParaHelloWorld()
        {
            // Arrange
            string palavra = "Hello World";

            // Act
            int wordCount = _validarStrings.ContarCaracteres(palavra);

            // Assert
            Assert.Equal(11, wordCount);
        }
    }
}