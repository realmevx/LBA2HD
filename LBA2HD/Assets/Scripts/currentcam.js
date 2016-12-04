#pragma strict

var camera1 : Camera;
 var camera2 : Camera;
 var camera3 : Camera;
 
 private var currCam : int = 0;
 
 function Start(){
     camera1.enabled=true;
     camera2.enabled=false;
     camera3.enabled=false;
     currCam = 0;
 }
 
 function Update(){
     if(Input.GetKeyDown("N")){
         currCam = ( currCam + 1 ) % 3;
         switch( currCam )
         {
             case 0 :
                 camera1.enabled=true;
                 camera2.enabled=false;
                 camera3.enabled=false;
             break;
             
             case 1 :
                 camera1.enabled=false;
                 camera2.enabled=true;
                 camera3.enabled=false;
             break;
             
             case 2 :
                 camera1.enabled=false;
                 camera2.enabled=false;
                 camera3.enabled=true;
             break;
         }
     }
 }