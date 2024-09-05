using CalculatorTDDChallenge;

namespace CalculatorTDDTests;

public class UnitTest1
{
    public Calculator buildCalculator()
    {
        string date = "01/01/2000";
        Calculator calculator = new Calculator(date);
        return calculator;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void Test1(int num1, int num2, int expected)
    {
        Calculator calc = buildCalculator();

        int result = calc.sum(num1, num2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 3, -1)]
    public void Test2(int num1, int num2, int expected)
    {
        Calculator calc = buildCalculator();

        int result = calc.sub(num1, num2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 3, 6)]
    public void Test3(int num1, int num2, int expected)
    {
        Calculator calc = buildCalculator();

        int result = calc.mult(num1, num2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(6, 3, 2)]
    public void Test4(int num1, int num2, int expected)
    {
        Calculator calc = buildCalculator();

        int result = calc.div(num1, num2);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        Calculator calc = buildCalculator();

        Assert.Throws<DivideByZeroException>(
            () => calc.div(10, 0)
        );
    }

    [Fact]
    public void TestGetHistory()
    {
        Calculator calc = buildCalculator();

        calc.sum(1, 2);
        calc.sub(1, 2);
        calc.mult(1, 2);

        Assert.NotEmpty(calc.getHistory());
        Assert.Equal(3, calc.getHistory().Count);
    }
}