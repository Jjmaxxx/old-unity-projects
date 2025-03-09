using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onDoorWayTriggerEnter += onDoorWayOpen;
        GameEvents.current.onDoorWayTriggerExit += onDoorWayClose;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onDoorWayOpen(int id){
        if(id == this.id){
            transform.Translate(new Vector3(0,1,0));
        }
    }
    void onDoorWayClose(int id){
        if(id == this.id){
            transform.Translate(0,-1,0);
        }
    }
}
