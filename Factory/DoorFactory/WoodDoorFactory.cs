using HouseBuilder.Model.Door;

namespace HouseBuilder.Factory.DoorFactory;

public class WoodDoorFactory : ADoorFactory
{
    public WoodDoorFactory(double width, double height) : base(width, height)
    {
    }

    public override ADoor Create()
    {
        return new WoodDoor(Width, Height);
    }
}