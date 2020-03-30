using UnityEngine;

public class _Plane : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;

    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
    }

    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }
    public void StartEngine()
    {
        m_Engine.StartEngine();
        m_Driver.Control(this);
    }
    public void TurnLeft()
    {
        Debug.Log("The " + m_Driver + " is turning left in the " + m_Engine + " plane.");
        transform.Rotate(0, -45, 0);
    }
    public void TurnRight()
    {
        Debug.Log("The " + m_Driver + " is turning right in the " + m_Engine + " plane.");
        transform.Rotate(0, 45, 0);
    }
}