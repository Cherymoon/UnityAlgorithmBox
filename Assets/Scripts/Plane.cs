using UnityEngine;

public class MPlane
{
    public Coords A;
    Coords B;
    Coords C;
    public Coords v;
    public Coords u;

    public MPlane(Coords _A, Coords _B, Coords _C)
    {
        A = _A;
        B = _B;
        C = _C;
        v = B - A;
        u = C - A;
    }

    public MPlane(Coords _A, Vector3 V, Vector3 U)
    {
        A = _A;
        v = new Coords(V.x, V.y, V.z);
        u = new Coords(U.x, U.y, U.z);
    }

    public MPlane(Vector3 _A, Vector3 _B, Vector3 _C)
    {
        A = new Coords(_A.x, _A.y, _A.z);
        B = new Coords(_B.x, _B.y, _B.z);
        C = new Coords(_C.x, _C.y, _C.z);
    }

    public Coords Lerp(float s, float t)
    {
        float xst = A.x + v.x * s + u.x * t;
        float yst = A.y + v.y * s + u.y * t;
        float zst = A.z + v.z * s + u.z * t;

        return new Coords(xst, yst, zst);
    }


}
