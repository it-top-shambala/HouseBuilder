using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory.WallFactory;

public abstract class AWallFactory : IFactory<AWall>
{
    public required double Height { get; init; }
    public required double Width { get; init; }

    protected AWallFactory(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public abstract AWall Create();
}