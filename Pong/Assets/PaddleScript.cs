using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        transform.Translate(0,Input.GetAxis("Vertical") * speed,0);

        //dont do two ifs just do it in a or 
        if(position.y >= 5.2f){
            //position is a propert and we cant alter it in this way, use a method or something 
            position.y = 5.2f;
            print("run for the love of god");
        }
        else if(position.y <= -5.2f){
            position.y = -5.2f;
        }
    }

}
