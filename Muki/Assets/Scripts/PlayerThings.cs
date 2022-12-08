using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThings : MonoBehaviour
{

    public int health = 5;
    public int Maxhealth = 5;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        health = Maxhealth;
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "Enemy")
        {
            health =- 1;
        }
    }





    // Update is called once per frame
    void Update()
    {
    }
}
