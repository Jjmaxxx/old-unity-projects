using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public Text timeLimit; 
    public Text Scoring;
    int frameTimer = 0;
    int startTimer = 20;
    int score = 0;
    Rigidbody rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ballMove();
        
    }
    void FixedUpdate(){
        timer();        
    }
    void ballMove(){
        if(Input.GetKey("a")){
            rb.AddForce(0,0,1 * speed);
        }
        if(Input.GetKey("d")){
            rb.AddForce(0,0,-1 * speed);
        }
        if(Input.GetKey("s")){
            rb.AddForce(-1 * speed,0,0);
        }
        if(Input.GetKey("w")){
            rb.AddForce(1 * speed,0,0);
        }                        
    }
    void timer(){
        //just use time.deltaTime
        if(frameTimer == 60){
            startTimer -= 1;
            frameTimer = 0;
        }
        if(startTimer == 0){
            SceneManager.LoadScene("GameOver");
        }
        frameTimer++;
        timeLimit.text = "Time: " + startTimer.ToString();
        Scoring.text = "Score: " + score.ToString();
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Teleporter"){
            SceneManager.LoadScene("Level 2"); 
        }
        if(other.gameObject.tag == "Points"){
            score += 1;
            Destroy(other.gameObject);
        }
    }
}
