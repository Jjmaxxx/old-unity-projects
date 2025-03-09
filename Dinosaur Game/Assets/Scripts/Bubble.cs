using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.15f,0,0);
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            //in player create function that ends game 
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "floorBorder"){
            Destroy(this.gameObject);
        }
    }
}
