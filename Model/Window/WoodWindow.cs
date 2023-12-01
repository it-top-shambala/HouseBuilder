namespace HouseBuilder.Model.Window;

public class WoodWindow : AWindow
{
    private const string MATERIAL = "Wood";
    
    public WoodWindow(double width, double height) : base(MATERIAL, width, height)
    {
    }
}