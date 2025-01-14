using Point = Engine.Vector3;

namespace Engine;

public class Ray
{
    public Point Origin { get; private set; }
    public Vector3 Direction { get; private set; }
    
    public Ray(Point origin, Vector3 direction)
    {
        Origin = origin;
        Direction = direction;
    }

    public Point At(float t)
    {
        return Origin + t * Direction;
    }
}