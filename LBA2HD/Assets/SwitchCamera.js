#pragma strict
  
  
 var show : boolean = true;
 var target : GameObject;
 var self : GameObject;
  
 function Update ()
 {
 
 if(Input.GetKeyDown("n"))
 	{
 if( show == true )
 		{
 target.SetActive(false);
 show = false;
 		}
 else
 		{
 target.SetActive(true);
 show = false;
 		}
 		{
 		self.SetActive(false);
 		}
 	}
 }