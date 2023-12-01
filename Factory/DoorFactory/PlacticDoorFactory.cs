using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public class PlacticDoorFactory : ADoorFactory
{
    public PlacticDoorFactory(double width, double height) : base(width, height)
    {
    }

    public override ADoor Create()
    {
        return new PlasticDoor(Width, Height);
    }
}