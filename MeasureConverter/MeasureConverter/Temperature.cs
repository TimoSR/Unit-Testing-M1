namespace MeasureConverter;

public class Temperature
{

    private readonly double _measurement;
    private readonly string _scaleConversionType;
    
    public Temperature(double measurement, string scaleConversionType)
    {
        _measurement = measurement;
        _scaleConversionType = scaleConversionType.ToUpper();
    }

    public decimal Convert()
    {
        
        decimal result = 0;

        switch (_scaleConversionType)
        {
            case "C TO F":
                result = (decimal)(_measurement * 1.8 + 32);
                break;
            case "C TO K":
                result = (decimal)(_measurement + 273.15);
                break;
            case "F TO C":
                result = (decimal)((_measurement - 32) / 1.8);
                break;
            case "F TO K":
                result = (decimal)((_measurement + 459.67) * 5 / 9);
                break;
            case "K TO C":
                result = (decimal)(_measurement - 273.15);
                break;
            case "K TO F":
                result = (decimal)(_measurement * 9 / 5 - 459.67);
                break;
        }

        return decimal.Round(result, 2);
    }

}