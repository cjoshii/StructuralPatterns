namespace Adapter;
public class RoundHole(int radious)
{
    public int Radious => radious;
    public bool CanFit(Cylinder cylinder)
    {
        return cylinder.Radious <= Radious;
    }
}