namespace HouseBuilder.Model.Door;

public class WoodDoor : ADoor
{
    private const string MATERIAL = "Wood";
    
    public WoodDoor(double width, double length) : base(MATERIAL, width, length)
    {
    }
}