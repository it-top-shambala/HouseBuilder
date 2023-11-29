namespace HouseBuilder.Model.Window;

public abstract class AWindow
{
    public required string Material { get; init; }
    public required double Width { get; init; }
    public required double Length { get; init; }

    protected AWindow(string material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }
}