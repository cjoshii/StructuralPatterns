namespace Adapter;
public class CubeAdapter : Cylinder
{
    private readonly Cube cube;
    public CubeAdapter(Cube cube) : base(0)
    {
        this.cube = cube;
    }

    public override int Radious => (int)(Math.Sqrt(2) * cube.Width / 2);
}
