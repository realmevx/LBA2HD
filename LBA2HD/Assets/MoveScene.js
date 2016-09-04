#pragma strict

var newScene : String;

function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("Player"))
	{
		SceneManagement.SceneManager.LoadScene ("scene2");
	}
}
	