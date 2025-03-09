using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public Transform sun;
    public GameObject planet;
    public float planetRangeConstant;
    public int numberOfPlanets;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = sunSize();
        numberOfPlanets = Random.Range(4,8);
        for(int i = 0; i<numberOfPlanets; i++){
            Instantiate(planet,transform.position,Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // sun.transform.Rotate(0,0,Random.Range(0.15f,1),Space.Self);

    }
    //this is the problem to literally everything you've tried in the past hour
    public float getMaxRange(){
        return transform.localScale.x * planetRangeConstant;
    }
    Vector3 sunSize(){
        float size = Random.Range(1.5f,3.0f);
        return new Vector3(size,size,0);
    }
}
