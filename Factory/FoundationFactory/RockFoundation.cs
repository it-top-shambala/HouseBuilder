using HouseBuilder.Factory.FundationFactory;

namespace HouseBuilder.Factory.FoundationFactory;

public class RockFoundation : AFoundationFactory
{
    public RockFoundation(double width, double length) : base(width, length)
    {
    }
    
    public override RockFoundation Create()
    {
        return new RockFoundation(Width, Length);
    }
}