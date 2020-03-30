using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Plane controlled by the player
        public _Plane m_PlayerPlane;
        // Plane controlled by an android (AI)
        public _Plane m_AndroidPlane;
        // Plane controlled by an alien (AI)
        public _Plane m_AlienPlane;
        // Plane controlled by a chicken (AI)
        public _Plane m_ChickenPlane;
        
        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();
            m_PlayerPlane.SetEngine(jetEngine);
            m_PlayerPlane.SetDriver(humanDriver);
            m_PlayerPlane.StartEngine();

            // Set up a bike with a AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();
            m_AndroidPlane.SetEngine(nitroEngine);
            m_AndroidPlane.SetDriver(androidDriver);
            m_AndroidPlane.StartEngine();

            // Set up a bike with a alien driver and a world engine
            IEngine worldEngine = new WorldEngine();
            IDriver alienDriver = new AlienDriver();
            m_AlienPlane.SetEngine(worldEngine);
            m_AlienPlane.SetDriver(alienDriver);
            m_AlienPlane.StartEngine();

            // Set up a bike with a chicken driver and a hydro engine
            IEngine hydroEngine = new HydroEngine();
            IDriver chickenDriver = new ChickenDriver();
            m_ChickenPlane.SetEngine(hydroEngine);
            m_ChickenPlane.SetDriver(chickenDriver);
            m_ChickenPlane.StartEngine();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerPlane.TurnLeft();
                m_AndroidPlane.TurnLeft();
                m_AlienPlane.TurnLeft();
                m_ChickenPlane.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerPlane.TurnRight();
                m_AndroidPlane.TurnRight();
                m_AlienPlane.TurnRight();
                m_ChickenPlane.TurnRight();
            }
        }
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
           
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}
