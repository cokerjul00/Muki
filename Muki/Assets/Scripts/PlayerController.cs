using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool canJump = false;

    public Vector2 turn;

    public float movementSpeed = 20.0f;
    public float jumpHeight = 5;
        
    Rigidbody myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 tempVelocity = myRB.velocity;
       { tempVelocity.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
        tempVelocity.z = Input.GetAxisRaw("Vertical") * movementSpeed;
        myRB.velocity = tempVelocity;
        }

        

        Vector3 velocity = myRB.velocity;
        

        if (canJump && Input.GetKeyDown(KeyCode.Space))
         {
                velocity.y = 5;
                myRB.velocity = velocity;
                canJump = false;
         }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            canJump = true;
    }

}
