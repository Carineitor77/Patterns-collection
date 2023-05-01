namespace Encapsulation;

public class BloodResult
{
    public BloodResult(double leukocytes, double platelets, double erythrocytes)
    {
        Leukocytes = leukocytes;
        Platelets = platelets;
        Erythrocytes = erythrocytes;
    }
    
    public double Leukocytes { get; }
    public double Platelets { get; }
    public double Erythrocytes { get; }

    public bool IsNormal()
        => Leukocytes is > 10 and < 100 
           && Platelets is > 25 and < 120 
           && Erythrocytes is > 15 and < 105;
}