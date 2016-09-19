using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkPlayer : NetworkBehaviour {
	[SyncVar] public string playerID;
	Camera playerCam;

	void Awake()
	{
		playerCam = GetComponentInChildren<Camera>();
		playerCam.gameObject.SetActive(false);
	}

	[Command]
	void CmdSetPlayerID(string newID)
	{
		playerID = newID;
	}

	public override void OnStartLocalPlayer ()
	{
		string myPlayerID = string.Format("Player {0}", netId.Value);
		CmdSetPlayerID(myPlayerID);
		playerCam.gameObject.SetActive(true);
	}
}