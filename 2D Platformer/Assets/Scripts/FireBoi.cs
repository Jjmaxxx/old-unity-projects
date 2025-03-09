using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoi : MonoBehaviour
{
    Vector2 originalPosition;
    
    public Rigidbody2D rb;
    public float force = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other) {
        //only resets the fireboi that collides with the player

        //a - reload the whole scene( might not work with the snowman lives and timer)
        //keep an array of all the firebois and reset all of them when this happens
        if(other.gameObject.tag == "Snowman"){
            gameObject.transform.position = originalPosition;
        }
    }

    //make a new child gameobject that just has the monster range collider
    //in the on collision enter function all you do if u touch the player is take the fireboi and move it 
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "MonsterRange"){
            //if statement to check if it moves left or right based on players relative position
            //is my x bigger than theirs?
            rb.AddForce(Vector2.left * force,ForceMode2D.Impulse);
            print("MonsterRange");
        }
        
    }
}
