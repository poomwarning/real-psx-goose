using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator _animator;
    public AudioSource dooropen;
    void Start()
    {
        _animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void pauseanim()
    {
        _animator.enabled = false;
    }
    void dooropensound()
    {
        dooropen.Play();
    }
    void doorclose()
    {
        dooropen.Play();
    }
   
}
