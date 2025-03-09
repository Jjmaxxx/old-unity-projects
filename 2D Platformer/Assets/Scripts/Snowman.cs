using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Snowman : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    public float force = 10.0f;
    public Text timeLimit;
    public LayerMask groundLayer;
    public Text lives;
    float frameTimer = 0;
    int startTimer = 99;
    int lifeCounter = 3;
    public Rigidbody2D rb;
    Vector2 originalPosition;      
 
    // public GameObject player;
    // Vector2 snowmanPosition;   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalPosition = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        move();
        death();
    }
    void FixedUpdate(){
        timer();        
    }

    void move(){
        transform.Translate(Input.GetAxis("Horizontal") * speed,0,0);
        //boolean if you've jumped or not and u just set the bool to true anytime you collide with a floor
        //make like a feet collider that checks only if your feet hit the ground

        if(Input.GetKeyDown("space")){
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            print("jump");
        }
    }
    
    void timer(){
        //TIMERS USE TIME.DELTATIME ALWAAAYS 

        if(frameTimer == 60){
            startTimer -= 1;
            frameTimer = 0;
        }
        if(startTimer == 0){
            SceneManager.LoadScene("GameOver");
        }
        //USE TIME.DELTATIME

        //round down or up Mathf.round()
        frameTimer += time.deltaTime;
        timeLimit.text = "MeltTime: " + startTimer.ToString();
    }
    void death(){
        //never ever ever ever unless you're checking if two things are the same thing (ie: checking if a tag is ==)
        //never us == to check thresholds
        //use <=
        if(lifeCounter <= 0){
            SceneManager.LoadScene("GameOver");
        }
        lives.text = "Lives: " + lifeCounter.ToString();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Fireboi"){
            //reset function maybe?
            gameObject.transform.position = originalPosition;
            lifeCounter -= 1;
            startTimer = 99;
        }

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "HeatCircle"){
            startTimer--;
        }
        if(other.gameObject.tag == "Portal"){
            startTimer = 99;
            SceneManager.LoadScene("Level2");
        }        
        if(other.gameObject.tag == "Border"){
            startTimer = 99;
            gameObject.transform.position = originalPosition;
            lifeCounter -= 1;
        }   

    }
}
