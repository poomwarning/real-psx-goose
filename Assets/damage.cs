using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    public  Image image;

    private Color tempColor;
    

     
   
    //SerailizeField is used to kept variable's value inside its script
    [SerializeField] public float hitforceup;
    [SerializeField] public float hitforceback;
    public float hpmax,hitdamage,hpreg;
    public float hpup;
    
    [SerializeField] bool hphold = false;
    public Vector3 knockbackImpact = Vector3.zero;
    public float playerMass = 3f;

    public float knockbackSpeed = 4f;

     
    Vector3 impact = Vector3.zero;

    public CharacterController character;
    

      void Start() 
     {
        tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;     
    }
    
 
    
    public void Knockback(Vector3 direction, float force)
    {
        direction.Normalize();
        if (direction.y < 0) direction.y = -direction.y; // reflect down force on the ground
        knockbackImpact += direction.normalized * force / playerMass;
    }
    
   

 
        void OnCollisionEnter(Collision hit) {
            
             
            if(hit.gameObject.tag == "enemy")
            {
              
                // GetComponent<Rigidbody>().AddForce(-transform.forward * hitforceback);
               // GetComponent<Rigidbody>().AddForce(transform.up * hitforceup);
                tempColor = image.color;
                // tempColor.a +=hitdamage/100;
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
                 character.Move(knockbackImpact * Time.deltaTime);
               knockbackImpact = Vector3.Lerp(knockbackImpact, Vector3.zero, knockbackSpeed * Time.deltaTime);
           
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
