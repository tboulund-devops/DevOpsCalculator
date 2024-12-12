namespace Tests;

public class SimpleCalculatorTest
{
    [Test]
    public void Add()
    {
        Calculator.SimpleCalculator simpleCalculator = new Calculator.SimpleCalculator();
        int result = simpleCalculator.Add(1, 2);
        Assert.That(result, Is.EqualTo(3));
    }
}