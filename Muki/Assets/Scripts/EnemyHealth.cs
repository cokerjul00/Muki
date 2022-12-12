using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Enemyhealth = 5.0f;

    GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
       Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemyhealth <= 0)
        {
            Object.Destroy(Enemy);
        }
           
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "axe")
        {
            Enemyhealth--;
        }
    }
}
