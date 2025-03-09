using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public Vector3 playerPosition;
    public float speed;
    Colors colors;
    
    Vector3 moveInDirection;



    // Start is called before the first frame update
    void Start()
    {
        colors = this.gameObject.GetComponent<Colors>();
        playerPosition = GameObject.FindWithTag("Player").transform.position;
        moveInDirection = (playerPosition - transform.position).normalized;
        speed = .8f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveInDirection * speed * Time.deltaTime; 
    }
    private void OnBecameInvisible() {
        Destroy(this.gameObject);    
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "tile"){
            Colors tileColor = other.gameObject.GetComponent<Colors>();
            if(tileColor.coloring == "red"){
                this.GetComponent<Renderer>().material.color = Color.red;       
                colors.coloring = "red";
            }
            else if(tileColor.coloring == "yellow"){
                this.GetComponent<Renderer>().material.color = Color.yellow;       
                colors.coloring = "yellow";
            }
            else if(tileColor.coloring == "blue"){
                this.GetComponent<Renderer>().material.color = Color.blue;       
                colors.coloring = "blue";
            }
            else if(tileColor.coloring == "white"){
                this.GetComponent<Renderer>().material.color = Color.white;       
                colors.coloring = "white";
            }
        }   
    }
}
