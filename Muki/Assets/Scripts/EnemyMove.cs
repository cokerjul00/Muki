using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    NavMeshAgent Enemy;
    GameObject player;
    private bool strafingPos1 = false;
    private bool strafingPos2 = false;
    private bool inRadius = false;

    public float strafingDistance = 10;

    public Vector3 Pathnode1;
    public Vector3 Pathnode2;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

        Pathnode1 = transform.position;
        Pathnode1.z -= strafingDistance;

        Pathnode2 = transform.position;
        Pathnode2.z += strafingDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRadius)
        {
            Enemy.SetDestination(player.transform.position);
        }

        else if (!inRadius)
        {
            if (!strafingPos1 && !strafingPos2)
                Enemy.SetDestination(Pathnode1);

            if (transform.position.x == Pathnode1.x && transform.position.z == Pathnode1.z)
            {
                Enemy.SetDestination(Pathnode2);

                strafingPos1 = false;
                strafingPos2 = true;
            }

            else if (transform.position.x == Pathnode2.x && transform.position.z == Pathnode2.z)
            {
                Enemy.SetDestination(Pathnode1);

                strafingPos1 = true;
                strafingPos2 = false;
            }
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bean")
            inRadius = true;
        strafingPos1 = false;
        strafingPos2 = false;
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Bean")
            inRadius = false;

    }

}
