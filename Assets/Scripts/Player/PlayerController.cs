using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    //public MouseLook mouseLook = new MouseLook();

    public float moveSpeed = 10f;

    private bool isGrounded = true;



    private Rigidbody playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ///
        //Controls character movement
        if(Input.GetButton("Horizontal"))
        {
            transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        }

        if(Input.GetButton("Vertical"))
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        }

        if(Input.GetButtonDown("Sprint"))
        {
            moveSpeed = moveSpeed * 2;
        }
        else if(Input.GetButtonUp("Sprint"))
        {
            moveSpeed = moveSpeed / 2;
        }

        if(Input.GetButton("Jump") && isGrounded)
        {
            Vector3 jumpForce = new Vector3(0, 10);
            playerRigidBody.AddForce(jumpForce);
        }


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
