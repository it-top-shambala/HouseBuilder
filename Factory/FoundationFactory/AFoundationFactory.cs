using HouseBuilder.Model.Foundation;
using RockFoundation = HouseBuilder.Factory.FoundationFactory.RockFoundation;

namespace HouseBuilder.Factory.FundationFactory;

public abstract class AFoundationFactory : IFactory<AFoundation>
{
    public double Width { get; init; }
    public double Length { get; init; }

    protected AFoundationFactory(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public abstract RockFoundation Create();
}