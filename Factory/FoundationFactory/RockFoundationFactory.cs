using HouseBuilder.Model.Foundation;

namespace HouseBuilder.Factory.FoundationFactory;

public class RockFoundationFactory : AFoundationFactory
{
    public RockFoundationFactory(double width, double length) : base(width, length)
    {
    }
    
    public override AFoundation Create()
    {
        return new RockFoundation(Width, Length);
    }
}