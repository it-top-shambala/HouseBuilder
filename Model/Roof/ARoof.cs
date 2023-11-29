namespace HouseBuilder.Model.Roof;

public abstract class ARoof
{
    public required string Material { get; init; }
    public required double Width { get; init; }
    public required double Length { get; init; }
    public required double Height { get; init; }

    protected ARoof(string material, double width, double length, double height)
    {
        Material = material;
        Width = width;
        Length = length;
        Height = height;
    }
}