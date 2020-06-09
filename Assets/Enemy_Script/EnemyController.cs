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
    private Level_Ctrl L_Ctrl;
    
    void Start()
    {       
        agent = GetComponent<NavMeshAgent>();
        Destination = agent.destination;
    }

    
    void Update()
    {
        
        if(Vector3.Distance(Destination,traget.position) < lookRadius)
        {
            Destination = traget.position ;
            agent.SetDestination(Destination);

            agent.speed = 4f;

        }
    }

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == ("Player"))
        {
            L_Ctrl.Scene_Changer();

        }
    }
}
