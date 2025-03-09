using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{

public int startAnimals;     // Start is called before the first frame update
public GameObject Animal;
    void Start()
    {
        for(int i=0; i<startAnimals; i++){
            //Quarternion identity corresponds to "no rotation" - the object is perfectly aligned with the world or parent axes.
            Instantiate(Animal,new Vector3(Random.Range(-20.0f,20.0f),0,Random.Range(-20.0f,20.0f)),Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
