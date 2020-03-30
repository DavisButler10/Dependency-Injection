using UnityEngine;

public class WorldEngine : IEngine
{
    public void StartEngine()
    {
        OpenWorldValve();
        Debug.Log("Engine started");
    }
    private void OpenWorldValve()
    {
        Debug.Log("The world engine thingy is open");
    }
}
