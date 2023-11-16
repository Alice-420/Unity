using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
  
   public GameObject car;
   AudioSource audioData;

    void Start() {
        audioData = GetComponent<AudioSource>();
    }

   void OnTriggerEnter (Collider player)
   {
    if (player.gameObject.tag == "Player") {
      Debug.Log ("Object Entered the sound trigger");
      Destroy(car);
      audioData.Play(0);
    }
   }

   void OnTriggerStay (Collider player)
   {
    Debug.Log ("Object is within trigger");
   }

   void OnTriggerExit (Collider player)
   {
    Debug.Log ("Object Exited the trigger");
    // audioData.Stop();
   }
}
