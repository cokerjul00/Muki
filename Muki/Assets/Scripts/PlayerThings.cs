using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThings : MonoBehaviour
{

    public int health = 3;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.name == "EnemyX")
        {
            int v = health--;
        }
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
