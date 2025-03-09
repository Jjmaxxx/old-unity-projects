using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRange : MonoBehaviour
{
    public List<GameObject> planetsInRange = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        print(planetsInRange);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Planet"){
            planetsInRange.Add(other.gameObject);
        }    
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Planet"){
            planetsInRange.Remove(other.gameObject);
        }       
    }
}
