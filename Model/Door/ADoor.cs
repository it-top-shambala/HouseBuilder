namespace HouseBuilder.Model.Door;

public abstract class ADoor
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Height { get; init; }

    protected ADoor(string material, double width, double height)
    {
        Material = material;
        Width = width;
        Height = height;
    }
}