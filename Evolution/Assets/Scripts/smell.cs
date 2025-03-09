using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smell : MonoBehaviour
{
    // Start is called before the first frame 
    AnimalMove am; 
    void Start(){
        am  = GetComponent < AnimalMove > ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onCollisionEnter(Collision collide){
        if(collide.gameObject.tag == "Food"){
            Vector3 foodJump = new Vector3(transform.parent.gameObject.transform.position.x - collide.gameObject.transform.position.x,0, transform.parent.gameObject.transform.position.z - collide.gameObject.transform.position.z);
            //transform.parent.gameObject.transform.Translate(FoodJump);
            print(foodJump);
            am.FoodJump(foodJump);
        }
    }
}
