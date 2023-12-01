using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory.WallFactory;

public class WoodWallFactory : AWallFactory
{
    public WoodWallFactory(double height, double width) : base(height, width)
    {
    }

    public override AWall Create()
    {
        return new WoodWall(Height, Width);
    }
}