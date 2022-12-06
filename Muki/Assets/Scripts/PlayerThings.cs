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

    public void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.name == "EnemyX")
        {
            health--;
        }
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
