using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory.WallFactory;

public class BrickWallFactory : AWallFactory
{
    public BrickWallFactory(double height, double width) : base(height, width)
    {
    }

    public override AWall Create()
    {
        return new BrickWall(Height, Width);
    }
}