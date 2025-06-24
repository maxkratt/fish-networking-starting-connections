using FishNet.Managing;
using UnityEngine;

public class ConnectionManager : MonoBehaviour
{
    [SerializeField] NetworkManager networkManager;

    public void StartHost()
    {
        StartServer();
        StartClient();
    }

    public void StartServer()
    {
        networkManager.ServerManager.StartConnection();
    }

    public void StartClient()
    {
        networkManager.ClientManager.StartConnection();
    }

    public void SetIPAddress(string text)
    {
        networkManager.TransportManager.Transport.SetClientAddress(text);
    }
}
