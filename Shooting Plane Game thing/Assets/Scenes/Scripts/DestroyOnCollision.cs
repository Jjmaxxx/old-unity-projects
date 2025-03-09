using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Asteroid;
    public int timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //can put it in another gameObject for better asteroid spawns; dont want to. like it how it is. adds more strategy to game
        
        //skipping a tick of the timer by doing this first
        //good habit is to put timer updates at the bottom of update functions
        //put timers in fixedupdate
        timer++;
        if(timer >= 100){
            Instantiate(Asteroid, new Vector2(Random.Range(-6,6),Random.Range(2,4)),Quaternion.identity);

        }
        //dupliate checks
        if(timer>=100){
            timer = 0;
        }     
        // print(timer);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Asteroid"){
            Destroy(other.gameObject);   
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Boundary"){
            Destroy(this.gameObject);
        }        
    }

}
