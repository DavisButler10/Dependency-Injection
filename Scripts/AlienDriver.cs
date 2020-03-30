using UnityEngine;

public class AlienDriver : IDriver
{
    private _Plane m_Plane;
    public void Control(_Plane plane)
    {
        m_Plane = plane;
        Debug.Log("This bike will be controlled by an Alien");
    }
}
