using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3
{
	public class PlayerController : NetworkBehaviour {

		void Update ()
		{
			if (!isLocalPlayer ) {
				return;
			}

			float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
			float z = Input.GetAxis("Vertical") * Time.deltaTime * 6.0f;

			transform.Rotate (0, x, 0);
			transform.Translate (0, 0, z);
		}
		
	}
}
