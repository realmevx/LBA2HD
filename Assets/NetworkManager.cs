private const string typeName = "UniqueGameName";
private const string gameName = "RoomName";
 
private void StartServer()
{
    Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
    MasterServer.RegisterHost(typeName, gameName);
}
void OnServerInitialized()
{
    Debug.Log("Server Initializied");
}
void OnGUI()
{
    if (!Network.isClient && !Network.isServer)
    {
        if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
            StartServer();
    }
}
