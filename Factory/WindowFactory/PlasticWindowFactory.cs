using HouseBuilder.Model.Window;

namespace HouseBuilder.Factory.WindowFactory;

public class PlasticWindowFactory : AWindowFactory
{
    public PlasticWindowFactory(double width, double height) : base(width, height)
    {
    }

    public override AWindow Create()
    {
        return new PlasticWindow(Width, Height);
    }
}