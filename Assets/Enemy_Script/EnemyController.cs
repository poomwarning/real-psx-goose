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
<<<<<<< HEAD
    private Level_Ctrl L_Ctrl;
=======
    public AudioSource chasesound;

>>>>>>> woody-prerelease
    
    void Start()
    {       
        agent = GetComponent<NavMeshAgent>();
        Destination = agent.destination;
<<<<<<< HEAD
=======
         chasesound.Play();
>>>>>>> woody-prerelease
    }

    
    void Update()
    {
        
        if(Vector3.Distance(Destination,traget.position) < lookRadius)
        {
            Destination = traget.position ;
            agent.SetDestination(Destination);
<<<<<<< HEAD

            agent.speed = 4f;
=======
           
           
>>>>>>> woody-prerelease

        }
    }

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }

<<<<<<< HEAD
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == ("Player"))
        {
            L_Ctrl.Scene_Changer();

        }
    }
=======
    
>>>>>>> woody-prerelease
}
