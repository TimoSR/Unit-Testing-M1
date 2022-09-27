namespace MeasureConverter.UnitTests;

[TestFixture]
public class TemperatureTests
{
    
    /*
     * Celsius
     */

    [Test]
    [TestCase(0, "C to F", 32)]
    [TestCase(100, "C to F", 212)]
    [TestCase(1000.532, "C to F", 1832.96)]
    public void Convert_Celsius_ToFahrenheit(
        double measurement, string convertFrom, decimal expectedInFahrenheit)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInFahrenheit));

    }

    [Test]
    [TestCase(0, "C to K", 273.15)]
    [TestCase(100, "C to K", 373.15)]
    [TestCase(1000.532, "C to K", 1273.68)]
    public void Convert_Celsius_ToKelvin(
        double measurement, string convertFrom, decimal expectedInKelvin)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInKelvin));
    }
    
    /*
     * Fahrenheit
     */
    
    [Test]
    [TestCase(0, "F to C", -17.78)]
    [TestCase(100, "F to C", 37.78)]
    [TestCase(1000.532, "F to C", 538.07)]
    public void Convert_Fahrenheit_ToCelsius(
        double measurement, string convertFrom, decimal expectedInCelsius)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInCelsius));
    }
    
    [Test]
    [TestCase(0, "F to K", 255.37)]
    [TestCase(100, "F to K", 310.93)]
    [TestCase(1000.532, "F to K", 811.22)]
    public void Convert_Fahrenheit_ToKelvin(
        double measurement, string convertFrom, decimal expectedInKelvin)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInKelvin));
    }
    
    /*
     * Kelvin
     */
    
    [Test]
    [TestCase(0, "K to C", -273.15)]
    [TestCase(100, "K To C", -173.15)]
    [TestCase(1000.532, "k to c", 727.38)]
    public void Convert_Kelvin_ToCelsius(
        double measurement, string convertFrom, decimal expectedInCelsius)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInCelsius));
    }
    
    [Test]
    [TestCase(0, "K to F", -459.67)]
    [TestCase(100, "K To F", -279.67)]
    [TestCase(1000.532, "k to F", 1341.29)]
    public void Convert_Kelvin_ToFahrenheit(
        double measurement, string convertFrom, decimal expectedInFahrenheit)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInFahrenheit));
    }
}