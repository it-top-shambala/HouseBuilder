namespace HouseBuilder.Model.Door;

public class PlasticDoor : ADoor
{
    private const string MATERIAL = "Plastic";
    
    public PlasticDoor(double width, double length) : base(MATERIAL, width, length)
    {
    }
}