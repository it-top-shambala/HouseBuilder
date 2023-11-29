namespace HouseBuilder.Model.Roof;

public class ThatchRoof : ARoof
{
    private const string MATERIAL = "Thatch";
    
    public ThatchRoof(double width, double length, double height) : base(MATERIAL, width, length, height)
    {
    }
}