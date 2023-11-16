using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimActivate2 : MonoBehaviour {
    public bool Ani; //ref to animator bool

    private Animator anim; //ref animator component
    private GameObject player;
    AudioSource audioData;

    void Start() {
        audioData = GetComponent<AudioSource>();
    }

    void Update () {
      anim = GetComponent<Animator>();
    }

   void OnTriggerEnter (Collider player) {
    Debug.Log ("Object Entered the anim trigger2");
    if (player.gameObject.tag == "Interact") {
      anim.SetBool("Ani", true);
    }
   }

   void OnTriggerStay (Collider player) {
    
    if (player.gameObject.tag == "Interact") {
      Debug.Log ("Object is within anim trigger2");
      anim.SetBool("Ani", true);
      audioData.Play(0);
    }
   }

   void OnTriggerExit (Collider player) {
    // if (player.gameObject.tag == "Player") {
    //   Debug.Log ("Object Exited the anim trigger2");
    //   anim.SetBool("Ani", false);
    // }
   }
}
