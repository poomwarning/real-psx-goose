using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    [SerializeField]
    Transform traget;
    [SerializeField]
    Vector3 Destination;
    NavMeshAgent agent;
    [SerializeField]
    bool isFollowing;
    [SerializeField]
    public AudioSource chasesound;

    
    void Start()
    {       
        agent = GetComponent<NavMeshAgent>();
        Destination = agent.destination;
         chasesound.Play();
    }

    
    void Update()
    {
        
        if(Vector3.Distance(Destination,traget.position) < lookRadius)
        {
            Destination = traget.position ;
            agent.SetDestination(Destination);
           
           

        }
    }

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }

    
}
