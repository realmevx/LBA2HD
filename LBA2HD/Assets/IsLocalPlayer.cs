using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3
{
	public class IsLocalPlayer : NetworkBehaviour {

		void Update ()
		{
			if (isLocalPlayer) {
				return;
			}
		}
	}
}