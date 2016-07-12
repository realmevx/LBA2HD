#pragma strict

var newScene : String;

function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("Player"))
	{
		Application.LoadLevel(newScene);
	}
}
	