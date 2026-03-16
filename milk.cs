
class Sud : Product
{
    public double FatPercent;
}

class Program
{
    static void Main()
    {
        Sud milk1 = new Sud();
        milk1.Name = "Azersud";
        milk1.Price = 2.50;
        milk1.FatPercent = 3.2;

        Sud milk2 = new Sud();
        milk2.Name = "Milla";
        milk2.Price = 2.80;
        milk2.FatPercent = 2.5;

        Sud milk3 = new Sud();
        milk3.Name = "Pinar";
        milk3.Price = 3.00;
        milk3.FatPercent = 1.5;

        Console.WriteLine($"{milk1.Name} - {milk1.Price} AZN - Yagliliq: {milk1.FatPercent}%");
        Console.WriteLine($"{milk2.Name} - {milk2.Price} AZN - Yagliliq: {milk2.FatPercent}%");
        Console.WriteLine($"{milk3.Name} - {milk3.Price} AZN - Yagliliq: {milk3.FatPercent}%");
    }
}
