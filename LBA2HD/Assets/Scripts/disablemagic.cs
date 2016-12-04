using UnityEngine;
using System.Collections;

public class disablemagic : MonoBehaviour {

	public MagicBall scriptMagicBall;

	void Start(){
		scriptMagicBall = GetComponent<MagicBall>();
	}  

	void Update(){
		if(Input.GetKeyDown (KeyCode.Escape)){ 
		}
			if(Input.GetKeyDown (KeyCode.Escape)){ 
			scriptMagicBall.enabled = !scriptMagicBall.enabled;
			}
	}
}