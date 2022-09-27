using System.Runtime.InteropServices.JavaScript;

namespace MeasureConverter;

public class Length
{
    private readonly double _number;
    private readonly string _numberSystem;
    
    public Length(double number, string numberSystem)
    {
        _number = number;
        _numberSystem = numberSystem.ToUpper();
    }

    public decimal Convert()
    {
        Decimal result = 0;

        if (_numberSystem == "METRIC")
        {
            result = new decimal(_number * 2.54);
        }
        else if (_numberSystem == "IMPERIAL")
        {
            result = new decimal(_number / 2.54);
        }

        return decimal.Round(result, 2, MidpointRounding.ToZero);
    }
}