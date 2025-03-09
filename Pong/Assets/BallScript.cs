using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float pushForce = 0.5f;
    public Rigidbody2D rb;
    Vector2 originalPosition;
    // Start is called before the first frame update
    public float randX;
    public float randY;

    public int score1 = 0;
    public int score2 = 0;

    void Start()
    {
        //basically calling on a variable and setting it to a rigidbody
        rb = GetComponent<Rigidbody2D>();
        //make x and y pos public fields
        originalPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        //no unneccesary type conversions, (this is converting to int then back to float)
        randX = -1;
        randY = 1;

    }

    // Update is called once per frame
    void Update(){  
        //dont translate initially, just add a force in this direction
        //if its an initial push just put it in start
        transform.Translate(-0.05f,0.05f,0);

        // Vector2 position = transform.position;
        // if(position.y >= 5){
        //     position.y *= -1;
        //     position.y = 4.99f;
        //     print("collision detected with top");
        // }
        // if(position.y >= -5){
        //     position.y *= -1;
            
        // }

    }

    private void OnTriggerEnter2D(Collider2D other) {

        //Vector2 position = transform.position;

            if(other.gameObject.tag == "Bounce"){
                //you're taking that rigidbody and adding force to make it bounce off walls.
                //ForceMode2D.Impulse makes it apply the force instantly
                rb.AddForce(Vector2.down * pushForce, ForceMode2D.Impulse);
                print("collision with bounce");
                
            }
            if(other.gameObject.tag == "Bounce2"){
               rb.AddForce(Vector2.up * pushForce, ForceMode2D.Impulse);
               print("collision with bounce");
            }
            if(other.gameObject.tag == "Paddle"){
                rb.AddForce(Vector2.left * pushForce, ForceMode2D.Impulse);
                print("collision with paddle");
            }            
            if(other.gameObject.tag == "Paddle2"){
                rb.AddForce(Vector2.right * pushForce, ForceMode2D.Impulse);
                print("collision with paddle");
            }           

            //just check if its position exceeds some bounds 
            //you could have bounds be a public field
            if(other.gameObject.tag == "returnBall"){
                gameObject.transform.position = originalPosition;
                GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
                randX = 1f;
                randY = 1f;
                score2 +=1;
            }                    
            //bad name
            if(other.gameObject.tag == "returnBallRight"){
                gameObject.transform.position = originalPosition;
                GetComponent<Rigidbody2D>().velocity = Vector2.zero; 
                randX = 1f;
                randY = 1f;
                score1 +=1;                
            }                              
        }
}

