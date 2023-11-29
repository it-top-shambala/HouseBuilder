using HouseBuilder.Factory.FoundationFactory;
using HouseBuilder.Factory.FundationFactory;

namespace HouseBuilder.Factory;

public interface IFactory<out T>
{
    public RockFoundation Create();
}