using System;
using System.Globalization;

class WeighingMachine
{
    public int Precision { get; }

    private double weight;
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            weight = value;
        }
    }

    public double TareAdjustment { get; set; } = 5.0;

    public string DisplayWeight
    {
        get
        {
            double displayWeight = Weight - TareAdjustment;
            return displayWeight.ToString("F" + Precision, CultureInfo.InvariantCulture) + " kg";
        }
    }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
class Program
{
    static void Main()
    {
       
        var wm = new WeighingMachine(precision: 3);
        Console.WriteLine($"Precision: {wm.Precision}");

        wm.Weight = 60.5;
        Console.WriteLine($"Weight: {wm.Weight}");

        try
        {
            wm.Weight = -10;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Weight negativo: se lanzó ArgumentOutOfRangeException");
        }

     
        Console.WriteLine($"TareAdjustment por defecto: {wm.TareAdjustment}");

      
        wm.TareAdjustment = -10.6;
        Console.WriteLine($"TareAdjustment asignado: {wm.TareAdjustment}");

       
        var wm2 = new WeighingMachine(precision: 3);
        wm2.Weight = 60.567;
        wm2.TareAdjustment = 10;
        Console.WriteLine($"DisplayWeight: {wm2.DisplayWeight}");
    }
}