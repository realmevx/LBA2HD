using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MagicBall_Soundhandler : MonoBehaviour
{
	public AudioClip[] sounds;
 
	void Awake() 
	{
	}
	
	void Start ()
	{
	}
	
	void Update()
	{
	}
	
	public void PlaySound()
	{	
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip = sounds[Random.Range(0, sounds.Length)];
		GetComponent<AudioSource>().Play();
	}

}