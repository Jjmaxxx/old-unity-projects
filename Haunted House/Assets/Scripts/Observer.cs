﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public GameEnding gameEnding;
    bool IsPlayerInRange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsPlayerInRange){
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;
            if(Physics.Raycast(ray, out raycastHit)){
                if(raycastHit.collider.transform == player){
                    gameEnding.CaughtPlayer();
                }
            }
        }
  
    }
    void OnTriggerEnter(Collider other) {
        if(other.transform == player){
            IsPlayerInRange = true;
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.transform == player){
            IsPlayerInRange = false;
        }
    }    
}
