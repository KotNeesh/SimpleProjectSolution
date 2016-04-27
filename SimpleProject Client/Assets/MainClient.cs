using UnityEngine;
using SimpleProject;

public class MainClient : MonoBehaviour
{
    public SceneMenu Menu;
    MessagesManager _messagesManager;
    NetworkMachine _network;
    ScenarioMachine _scenario;
    
    //Start function
    public void Start ()
    {
        _messagesManager = new MessagesManager();
        _network = new NetworkMachine(_messagesManager);
        //_scene = new SceneMenu(_network.GetUser());
        Parameters p = new Parameters(_messagesManager, Menu);
        _scenario = new ScenarioMachine(p);
        _scenario.AddScenario(_messagesManager);
        _scenario.AddScenario(Menu.GetScenario());
        _network.Start();
        _scenario.Start();
    }
    public void OnGUI()
    {
        //_scene.OnGUI();
    }
	


    public void OnDestroy()
    {
        if (_network != null) _network.Close();
        if (_scenario != null) _scenario.Close();
    }
}
