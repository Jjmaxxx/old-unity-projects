using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Start is called before the first frame update
    public int timer = 0; 
    public Light sun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer >= 14400){
            timer = 0;
        }
        timer++;
        if(timer%600 == 0){
            sun.transform.Rotate(90,0,0);
        }
    }
}
