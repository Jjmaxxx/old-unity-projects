using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 20f;
    Vector3 m_Movement;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource audioSource;
    Quaternion m_Rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        //Its getting a reference from a component of type Animator
        m_Animator = GetComponent<Animator> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        m_Movement.Set(horizontal, 0f, vertical);   
        //changes everything to move the same speed
        m_Movement.Normalize ();     
        //if both floars are approximately the same it will return true
        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f); 
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);  
        //returns true if both bools are true
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        //first value is var name and second value is what you want to set it to
        m_Animator.SetBool ("IsWalking", isWalking);
        if(isWalking){
            if(!audioSource.isPlaying){
                audioSource.Play();
            }
        }
        else{
            audioSource.Stop();
        } 
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        //Quaternions store rotations
        m_Rotation = Quaternion.LookRotation (desiredForward);
    }
    void OnAnimatorMove()
    {
        // deltaPosition is the change in position due to root motion that would have been applied to this frame
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation (m_Rotation);

    }
}
