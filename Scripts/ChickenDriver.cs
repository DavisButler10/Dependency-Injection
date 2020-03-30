using UnityEngine;

public class ChickenDriver : IDriver
{
    private _Plane m_Plane;
    public void Control(_Plane plane)
    {
        m_Plane = plane;
        Debug.Log("This plane will be controlled by a Chicken");
    }
}
