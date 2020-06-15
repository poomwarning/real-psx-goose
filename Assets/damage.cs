using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    public  Image image;

    private Color tempColor;
    
    public GameObject player;
    
   
    //SerailizeField is used to kept variable's value inside its script
    [SerializeField] public float hitforceup;
    [SerializeField] public float hitforceback;
    public float hpmax,hitdamage,hpreg;
    public float hpup;
    
    [SerializeField] bool hphold = false;

    public CharacterController character;

    

    private knockback knockback;
    

      void Start() 
     {
         knockback = player.GetComponent<knockback>();
        tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;     
    }
    
 
    

    
   

 
        void OnCollisionEnter(Collision hit) {
            
             
            if(hit.gameObject.tag == "enemy")
            {
               knockback.AddImpact(player.transform.position,70f);
                // GetComponent<Rigidbody>().AddForce(-transform.forward * hitforceback);
                // GetComponent<Rigidbody>().AddForce(transform.up * hitforceup);
                tempColor = image.color;
                tempColor.a +=hitdamage/100;
                image.color = tempColor;
                hpup -= hitdamage;
                hphold = true;  
                StartCoroutine(hpdel());
                return;
                //hpimage.updatehp(hpup);
            }
        }
        

        IEnumerator hpdel()
        {
            yield return new WaitForSeconds(5);
            hphold = false;
        }

      void Update() {
                 
           
            if(hphold == false){
            hpup += hpreg * Time.deltaTime;
            tempColor = image.color;
                 tempColor.a -=(hpreg/100)*Time.deltaTime;
                 image.color = tempColor;
           
            }
            if(hpup > 100){
               tempColor = image.color;
                 tempColor.a =0f;
                 image.color = tempColor;
                hpup = hpmax;
            }
            if(hpup <= 0){
               // Destroy(gameObject);
            }
        }
        
}
