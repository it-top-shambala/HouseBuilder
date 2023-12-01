using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public abstract class ADoorFactory : IFactory<ADoor>
{
    public double Width { get; init; }
    public double Height { get; init; }

    protected ADoorFactory(double width, double height)
    {
        Width = width;
        Height = height;
    }
    
    public abstract ADoor Create();
}