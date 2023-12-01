namespace HouseBuilder.Model.Window;

public abstract class AWindow
{
    public string Material { get; init; }
    public double Width { get; init; }
    public double Height { get; init; }

    protected AWindow(string material, double width, double height)
    {
        Material = material;
        Width = width;
        Height = height;
    }
}