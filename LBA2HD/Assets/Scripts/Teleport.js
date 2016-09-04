#pragma strict

var target : Transform;

function Update () {

}

function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("teleport"))
	{
		this.transform.position = target.position;
	}
		
}