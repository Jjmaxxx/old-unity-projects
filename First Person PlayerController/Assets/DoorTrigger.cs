using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            GameEvents.current.doorWayTriggerEnter(id);
        }
    }
    private void OnTriggerExit(Collider other) {
        GameEvents.current.doorWayTriggerExit(id);
    }
}
