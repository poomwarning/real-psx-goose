using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMOVEMENT : MonoBehaviour
{
    public CharacterController controller;

    CharacterController cc;

    public float speed = 12f;

    
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public float jumpHeight = 3f;

    public float old_pos;


    Vector3 velocity;
    bool isGrounded;
    bool isSprinting;
    // Start is called before the first frame update
    void Start()
    {
         old_pos = transform.position.x;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        
       if(isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right*x+transform.forward*z;
         if(Input.GetButton("sprint") && (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)))
        {
            speed = 6f;
            GetComponent<AudioSource>().pitch = Random.Range(1.5f,2.5f);
        }
        else
        {
            speed = 4f;
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
        }
        
       
        controller.Move(move*speed*Time.deltaTime);
       
        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);
        }
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

        if(cc.isGrounded == true  && GetComponent<AudioSource>().isPlaying == false && (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)))
		{
			GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
			GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
			GetComponent<AudioSource>().Play();
		}
        
    }
}
