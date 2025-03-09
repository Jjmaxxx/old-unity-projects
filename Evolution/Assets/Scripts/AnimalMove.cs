using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     
        //position is var name
        Vector3 position =  new Vector3(Random.Range(-.2f,.2f)* speed,0,Random.Range(-.2f,.2f) * speed);

        if(position.x + transform.position.x > 20 || position.x + transform.position.x < -20){
            position.x *= -1;
        }
        if(position.z + transform.position.z > 20 || position.z + transform.position.z < -20){
            position.z *= -1;
        }        
        transform.Translate(position);    
    }
    public void FoodJump(Vector3 jump){
        transform.Translate(jump);
    }
}
