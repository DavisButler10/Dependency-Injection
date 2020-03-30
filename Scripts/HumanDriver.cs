using UnityEngine;

public class HumanDriver : IDriver
{
    private _Plane m_Plane;
    public void Control(_Plane plane)
    {
        m_Plane = plane;
        Debug.Log("A human (player) will control the plane");
    }
}