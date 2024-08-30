using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calculadora.Add(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveRetornarTruePara6PoisEPar()
    {
        // Arrange
        int num = 10;

        // Act
        bool resultado = _calculadora.IsEven(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(9)]
    public void DeveRetornarTrueParaPar(int num)
    {
        // Act
        bool resultado = _calculadora.IsEven(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8 })]
    [InlineData(new int[] { 1, 3, 5, 7 })]
    public void DeveRetornarTrueParaPares(int[] nums)
    {
        // Act / Assert
        // foreach (int num in nums)
        // {
        //     Assert.True(_calculadora.IsEven(num));
        // }

        Assert.All(nums, num => Assert.True(_calculadora.IsEven(num)));
    }

}