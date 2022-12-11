using UnityEngine;
using UnityEngine.AI;

public class EnemyRandom : MonoBehaviour
{

    public float wanderRadius;
    public float wanderTimer;

    NavMeshAgent Enemy;
    GameObject player;
    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    private bool inRadius = false;

    private void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
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

            timer += Time.deltaTime;


            if (timer >= wanderTimer)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;


    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bean")
            inRadius = true;
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "Bean")
            inRadius = false;

    }
}