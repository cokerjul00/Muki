using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThings : MonoBehaviour
{

    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
