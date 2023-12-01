using HouseBuilder.Model.Window;

namespace HouseBuilder.Factory.WindowFactory;

public abstract class AWindowFactory : IFactory<AWindow>
{
    public double Width { get; init; }
    public double Height { get; init; }

    protected AWindowFactory(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public abstract AWindow Create();
}