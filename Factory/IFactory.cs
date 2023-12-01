using HouseBuilder.Factory.FoundationFactory;
using HouseBuilder.Model.Foundation;
using HouseBuilder.Model.Wall;

namespace HouseBuilder.Factory;

public interface IFactory<out T>
{
    public AFoundation Create();
}