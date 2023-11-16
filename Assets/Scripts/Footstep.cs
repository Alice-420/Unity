using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{

   CharacterController cc;
 void Start () {
        cc = GetComponent<CharacterController>();
 }
 
 // Update is called once per frame
 void Update () {
        if (cc.isGrounded == true && cc.velocity.magnitude > 1f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
 }
}
