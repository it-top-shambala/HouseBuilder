using HouseBuilder.Model.Foundation;
using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory.FoundationFactory;

public abstract class AFoundationFactory : IFactory<AFoundation>
{
    public double Width { get; init; }
    public double Length { get; init; }

    protected AFoundationFactory(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public abstract AFoundation Create();
}