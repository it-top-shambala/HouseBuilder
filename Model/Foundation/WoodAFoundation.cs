namespace HouseBuilder.Model.Foundation;

public class WoodAFoundation : AFoundation
{
    private const string MATERIAL = "Wood";

    public WoodAFoundation(double width, double length) : base(MATERIAL, width, length)
    { }
}