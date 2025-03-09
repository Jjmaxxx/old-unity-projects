using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public GameObject ball;
    private int frameCount =0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed,0,0);
        if(frameCount> 119){
           Instantiate(ball, new Vector2(Random.Range(-14.0f,14.0f),6.0f), Quaternion.identity);
            frameCount = 0;
        }

        frameCount++;
    }
}
