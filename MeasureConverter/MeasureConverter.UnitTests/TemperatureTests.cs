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
    public void Convert_Celsius_To_Fahrenheit(
        double measurement, string convertFrom, double expectedInFahrenheit)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInFahrenheit));

    }

    [Test]
    [TestCase(0, "C to K", 273.15)]
    [TestCase(100, "C to K", 373.15)]
    [TestCase(1000.532, "C to K", 1273.68)]
    public void Convert_Celsius_To_Kelvin(
        double measurement, string convertFrom, double expectedInKelvin)
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
    public void Convert_Fahrenheit_To_Celsius(
        double measurement, string convertFrom, double expectedInCelsius)
    {
        var temperature = new Temperature(measurement, convertFrom);

        var result = temperature.Convert();
        
        Assert.That(result, Is.EqualTo(expectedInCelsius));
    }
    
    [Test]
    public void Convert_Fahrenheit_To_Kelvin()
    {
    }
    
    /*
     * Kelvin
     */
    
    [Test]
    public void Convert_Kelvin_To_Celsius()
    {
    }
    
    [Test]
    public void Convert_Kelvin_To_Fahrenheit()
    {
    }
}