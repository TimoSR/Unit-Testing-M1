using System.Runtime.InteropServices.JavaScript;

namespace MeasureConverter;

public class Length
{
    private double number;
    private string numberSystem;
    
    public Length(double number, string numberSystem)
    {
        this.number = number;
        this.numberSystem = numberSystem.ToUpper();
    }

    public Decimal Convert()
    {

        Decimal result = 0;

        if (numberSystem == "METRIC")
        {
            result = new decimal(number * 2.54);
        }
        else if (numberSystem == "IMPERIAL")
        {
            result = new decimal(number / 2.54);
        }

        return Decimal.Round(result, 2, MidpointRounding.ToZero);
    }

}