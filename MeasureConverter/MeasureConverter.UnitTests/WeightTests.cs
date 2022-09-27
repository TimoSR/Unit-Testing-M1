namespace MeasureConverter.UnitTests;

[TestFixture]
public class WeightTests
{
    
    Weight _weight = new Weight();
    
    [SetUp]
    public void Setup()
    {
        // Arrange
        _weight = new Weight();
    }

    [Test]
    [TestCase(0, "IMPERIAL", 0)]
    [TestCase(0.21, "Imperial", 0.46)]
    [TestCase(1, "IMPERIaL", 2.20 )]
    [TestCase(1000, "imperial", 2204.62)]
    
    public void Convert_Kilograms_ToPounds(double numberInKg, string convertToPounds, decimal expectedInPounds)
    {
        // Act
        var result = _weight.Converter(numberInKg, convertToPounds);

        // Assert
        Assert.AreEqual(result, expectedInPounds);

    }
    
    [Test]
    [TestCase(0, "Metric", 0)]
    [TestCase(0.5, "METRIC", 0.23)]
    [TestCase(1, "METRIC", 0.45)]
    [TestCase(1000, "metric", 453.59)]
    public void Convert_Pounds_ToKilograms(double numberInPounds, string convertToKG, decimal expectedInKg)
    {
        // Act
        var result = _weight.Converter(numberInPounds, convertToKG);

        // Assert
        Assert.AreEqual(result, expectedInKg);
    }

}