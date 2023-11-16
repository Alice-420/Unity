using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelchair : MonoBehaviour
{
    
    [SerializeField] private Animator myAnimationController;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wheel Chair_Transport"))
        {
            myAnimationController.SetBool("HumanAnim",true);
        }
    }
    
    private void OnTriggerEx(Collider other)
    {
        if (other.CompareTag("Wheel Chair_Transport"))
        {
            myAnimationController.SetBool("HumanAnim", false);
        }
    }
}
