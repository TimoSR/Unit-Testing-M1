namespace MeasureConverter.UnitTests;

[TestFixture]
public class LengthTests
{

    [Test]
    [TestCase(0, "Imperial", 0)]
    [TestCase(0.5, "Imperial", 0.19 )]
    [TestCase(1, "Imperial", 0.39)]
    [TestCase(1000, "Imperial",393.70)]
    public void Convert_GivenMetric_ReturnsImperial(double numberInCm, string convertToInches, decimal expectedInInches)
    {
        // Arrange
        var length = new Length(numberInCm, convertToInches);
        
        // Act
        var result = length.Convert();
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedInInches));
    }
    
    [Test]
    [TestCase(0, "Metric", 0)]
    [TestCase(3.94, "Metric", 10)]
    [TestCase(0.39, "Metric" , 0.99)]
    [TestCase(1000, "Metric", 2540)]
    public void ConvertLength_GivenImperial_ReturnsMetric(double numberInInches, string convertToCM, decimal expectedInCm)
    {
        // Arrange
        var length = new Length(numberInInches, convertToCM);
        
        // Act
        var result = length.Convert();
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedInCm));
    }
}