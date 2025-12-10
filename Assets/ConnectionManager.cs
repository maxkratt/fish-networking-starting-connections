using FishNet.Managing;
using UnityEngine;

public class ConnectionManager : MonoBehaviour
{
    [SerializeField] private NetworkManager NetworkManager;

    public void StartHost()
    {
        StartServer();
        StartClient();
    }

    public void StartServer()
    {
        NetworkManager.ServerManager.StartConnection();
    }

    public void StartClient()
    {
        NetworkManager.ClientManager.StartConnection();
    }

    public void SetIPAddress(string text)
    {
        NetworkManager.TransportManager.Transport.SetClientAddress(text);
    }
}
