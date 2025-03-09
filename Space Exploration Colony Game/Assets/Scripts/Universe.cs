using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    public int numberOfSuns;
    public float distanceFromOtherSuns;
    public GameObject sun;
   // private List<Sun> Suns;
    public float universeSize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // void generateUniverse(){
    //     Vector3 sunPosition = new Vector3(Random.Range(universeSize/2 * -1, universeSize/2),Random.Range(universeSize/2 * -1, universeSize/2),Random.Range(universeSize/2 * -1, universeSize/2));
    //     for(int i=0;i<Suns.Count;i++){
    //         if(Vector3.distance(Suns[i].transform,sunPosition)<distanceFromOtherSuns){
    //             sunPosition = new Vector3(Random.Range(universeSize/2 * -1, universeSize/2),Random.Range(universeSize/2 * -1, universeSize/2),Random.Range(universeSize/2 * -1, universeSize/2));
    //             i = 0;
    //         }
    //     }
    // }
}
