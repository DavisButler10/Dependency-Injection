using UnityEngine;

public class HydroEngine : IEngine
{
    public void StartEngine()
    {
        OpenHydroValve();
        Debug.Log("Engine started");
    }
    private void OpenHydroValve()
    {
        Debug.Log("The hydro valve is open");
    }
}
