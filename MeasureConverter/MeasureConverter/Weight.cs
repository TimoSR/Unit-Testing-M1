namespace MeasureConverter;

public class Weight
{

    private string? _numberSystem;
    
    public decimal Converter(double weight, string numberSystem)
    {
        
        decimal result = 0;

        _numberSystem = numberSystem.ToUpper();

        if (_numberSystem == "METRIC")
        {
            result = new decimal(weight / 2.20462);
        } 
        else if (_numberSystem == "IMPERIAL")
        {
            result = new decimal(weight * 2.20462);
        }

        return decimal.Round(result, 2);
    }
}