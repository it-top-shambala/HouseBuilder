using HouseBuilder.Model.Window;

namespace HouseBuilder.Factory.WindowFactory;

public class WoodWindowFactory : AWindowFactory
{
    public WoodWindowFactory(double width, double height) : base(width, height)
    {
    }

    public override AWindow Create()
    {
        return new WoodWindow(Width, Height);
    }
}