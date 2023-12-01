using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory.WallFactory;

public abstract class AWallFactory : IFactory<AWall>
{
    public required double Height { get; init; }
    public required double Weight { get; init; }

    protected AWallFactory(double height, double weight)
    {
        Height = height;
        Weight = weight;
    }

    public abstract AWall Create();
}