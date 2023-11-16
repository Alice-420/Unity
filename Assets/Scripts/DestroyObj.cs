using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
  
   public GameObject obj;
   public GameObject obj2;

  

   void OnTriggerEnter (Collider player)
   {
    Debug.Log ("Object Entered the destroy trigger");
    
   }

   void OnTriggerStay (Collider player)
   {
    if (player.gameObject.tag == "Interact") {
    	Debug.Log ("Object is being destroyed");
    	Destroy(obj);
      Destroy(obj2);
    }
   }

   void OnTriggerExit (Collider player)
   {
    Debug.Log ("Object Exited the destroy trigger");
   }
}
