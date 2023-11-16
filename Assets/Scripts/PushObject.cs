using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
private Rigidbody rb;
    private bool isGrounded;
    private bool jumpingCondition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            jumpingCondition = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpingCondition && isGrounded)
            Jump();
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0f, 3f, 0f), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Ground")
        {
            isGrounded = true;
            jumpingCondition = false;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
