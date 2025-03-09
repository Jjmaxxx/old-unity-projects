using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public int frameCounter;
    public Light sun;
    // Start is called before the first frame update
    void Start()
    {
        frameCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
           frameCounter++;
        if(frameCounter> 14400){
            frameCounter = 0;
        }
        if(frameCounter%600 == 0){
            sun.transform.Rotate(15,0,0);
        }
    }
}
