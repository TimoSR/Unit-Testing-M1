namespace MeasureConverter.UnitTests;

[TestFixture]
public class LengthTests
{

    [Test] 
    [TestCase(1, "Imperial", 0.39)] 
    [TestCase(10, "Imperial", 3.93)]
    [TestCase(1000, "Imperial",393.70)]
    public void Convert_GivenMetric_ReturnsImperial(double numberInMetric, string numberSystem, double expectedInInches)
    {
        // Arrange
        var length = new Length(numberInMetric, numberSystem);
        
        // Act
        var result = length.Convert();
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedInInches));
    }
    
    [Test]
    [TestCase(3.94, "Metric", 10)]
    [TestCase(0.39, "Metric" , 0.99)]
    [TestCase(1000, "Metric", 2540)]
    public void ConvertLength_GivenImperial_ReturnsMetric(double numberInInches, string numberSystem, double expectedInCm)
    {
        // Arrange
        var length = new Length(numberInInches, numberSystem);
        
        // Act
        var result = length.Convert();
        
        // Assert
        Assert.That(result, Is.EqualTo(expectedInCm));
    }
}