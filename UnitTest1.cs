using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }
    // Тесты для Add
    [Test]
    public void Add_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(5, _calculator.Add(2, 3));
        Assert.AreEqual(-1, _calculator.Add(2, -3));
        Assert.AreEqual(0, _calculator.Add(0, 0));
    }
    // Тесты для Subtract
    [Test]
    public void Subtract_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(1, _calculator.Subtract(3, 2));
        Assert.AreEqual(5, _calculator.Subtract(2, -3));
        Assert.AreEqual(0, _calculator.Subtract(0, 0));
    }
    // Тесты для Multiply
    [Test]
    public void Multiply_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(6, _calculator.Multiply(2, 3));
        Assert.AreEqual(-6, _calculator.Multiply(2, -3));
        Assert.AreEqual(0, _calculator.Multiply(0, 5));
    }
    // Тесты для Divide
    [Test]
    public void Divide_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(2.0, _calculator.Divide(6, 3));
        Assert.AreEqual(-2.0, _calculator.Divide(6, -3));
        Assert.AreEqual(0.0, _calculator.Divide(0, 5));
    }

    [Test]
    public void Divide_ShouldThrowDivideByZeroException()
    {
        var ex = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        Assert.AreEqual("Division by zero is not allowed.", ex.Message);
    }
    // Тесты для Power
    [Test]
    public void Power_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(8.0, _calculator.Power(2, 3));
        Assert.AreEqual(0.25, _calculator.Power(2, -2));
        Assert.AreEqual(1.0, _calculator.Power(5, 0));
    }

    [Test]
    public void Power_ShouldThrowArgumentExceptionForZeroToNegativePower()
    {
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Power(0, -1));
        Assert.AreEqual("Cannot raise zero to a negative power.", ex.Message);
    }
}