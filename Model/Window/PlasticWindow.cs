namespace HouseBuilder.Model.Window;

public class PlasticWindow : AWindow
{
    private const string MATERIAL = "Plastic";
    
    public PlasticWindow(double width, double length) : base(MATERIAL, width, length)
    {
    }
}