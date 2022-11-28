using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    NavMeshAgent Enemy;
    GameObject player;
    private bool inRadius = false;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (inRadius == true)
        {
            Enemy.SetDestination(player.transform.position);
        }
        if (inRadius == false)
        {
            Enemy.SetDestination(Enemy.transform.position);
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Bean")
            inRadius = true;
            
    }

    public void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.name == "Bean")
            inRadius = false;

    }

}
