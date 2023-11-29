namespace HouseBuilder.Model.Foundation;

public class RockFoundation : AFoundation
{
    private const string MATERIAL = "Rock";
    
    public RockFoundation(double width, double length) : base(MATERIAL, width, length)
    {
    }
}