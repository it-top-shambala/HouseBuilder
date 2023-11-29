namespace HouseBuilder.Model.Roof;

public class WoodRoof : ARoof
{
    private const string MATERIAL = "Wood";
    
    public WoodRoof(double width, double length, double height) : base(MATERIAL, width, length, height)
    {
    }
}