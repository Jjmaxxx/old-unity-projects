using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public long currency;
    public string nameOfPlayer;
    public List<Planet> discoveredPlanets;
    public List<Planet> colonizedPlanets;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool lose(){
        if(colonizedPlanets.Count <= 0){
            return true;
        } else{
            return false;
        }
    }
    public void pruneDeadPlanets(){
        for(int i = 0; i<colonizedPlanets.Count; i++){
            if(colonizedPlanets[i].isPlanetDead()){
                colonizedPlanets.RemoveAt(i);
            }
        }
    }
}
