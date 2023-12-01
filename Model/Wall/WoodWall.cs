namespace HouseBuilder.Model.Wall;

public class WoodWall : AWall
{
    private const string MATERIAL = "Wood";
    
    public WoodWall(double height, double width) : base(MATERIAL, height, width)
    {
    }
}