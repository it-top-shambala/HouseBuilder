using HouseBuilder.Model.Roof;

namespace HouseBuilder.Factory.RoofFactory;

public class WoodRoofFactory : ARoofFactory
{
    public WoodRoofFactory(double width, double length, double height) : base(width, length, height)
    {
    }

    public override ARoof Create()
    {
        return new WoodRoof(Width, Length, Height);
    }
}