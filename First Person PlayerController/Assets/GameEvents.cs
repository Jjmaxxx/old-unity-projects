using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    void Awake() {
        current = this;
    }

    public event Action<int> onDoorWayTriggerEnter;
    public void doorWayTriggerEnter(int id){
        if(onDoorWayTriggerEnter != null){
            onDoorWayTriggerEnter(id);
        }
    }
    public event Action<int> onDoorWayTriggerExit;
    public void doorWayTriggerExit(int id){
        if(onDoorWayTriggerExit != null){
            onDoorWayTriggerExit(id);
        }
    }
}
