namespace HouseBuilder.Model.Door;

public abstract class ADoor
{
    public required string Material { get; init; }
    public required double Width { get; init; }
    public required double Length { get; init; }

    protected ADoor(string material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }
}