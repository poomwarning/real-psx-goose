using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RevolverDamage : MonoBehaviour
{
    public GameObject Olayer;
    public AudioSource bosshurt;
    public GameObject snow;
    public GameObject blocking;
    public AudioSource itsover;
    public GameObject hurtsound;
    public GameObject blood;
    public GameObject enemy ;
    public GameObject bossmusic;
    public Animator boss;
    [SerializeField] NavMeshAgent agent;
    
[SerializeField] float enemyhp = 6;
[SerializeField] public float enemyhitforceback;
[SerializeField] public float enemyhitforceup;
void OnTriggerEnter(Collider bullet) 
    {
        if(bullet.gameObject.name == "bulletline")
            {
                if(Revolvershoot.shoot==true)
                {
                   enemy.GetComponent<Rigidbody>().AddForce(-transform.forward * enemyhitforceback);
                    GetComponent<Rigidbody>().AddForce(transform.up * enemyhitforceup);
                    bosshurt.Play();
                    enemyhp--;
                    if(enemyhp <= 0)
                        {
                            blocking.SetActive(false);
                            snow.SetActive(true);
                            Destroy(blood);
                            hurtsound.GetComponent<AudioSource>().enabled = false;
                            Olayer.GetComponent<damage>().enabled = false;
                            Olayer.GetComponent<knockback>().enabled = false;
                            bossmusic.GetComponent<AudioSource>().enabled = false;
                            enemy.GetComponent<AudioSource>().enabled = false;
                            boss.SetBool("dead",true);
                            agent.speed = 0f;
                            Invoke("endingmus",2f);
                        }
                    Debug.Log(enemyhp);
                }
                
            }
    }
    void endingmus()
    {
        itsover.Play();
    }
}