namespace HouseBuilder.Model.Foundation;

public class WoodFoundation : AFoundation
{
    private const string MATERIAL = "Wood";

    public WoodFoundation(double width, double length) : base(MATERIAL, width, length)
    { }
}