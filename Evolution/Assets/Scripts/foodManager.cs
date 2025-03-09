using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodManager : MonoBehaviour
{
    public int numberOfFood;
    public GameObject food;
    DayNightCycle time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<DayNightCycle>();
    }

    // Update is called once per frame
    void Update()
    {

        if(time.frameCounter == 360){
            for(int i = 0; i<numberOfFood; i++){
                Instantiate(food,new Vector3(Random.Range(-20.0f,20.0f),0,Random.Range(-20.0f,20.0f)),Quaternion.identity);
            }
        }
    }
}
