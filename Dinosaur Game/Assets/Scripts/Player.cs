using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Text Timer;
    public float startTimer = 0;
    public float jumpForce = 1.0f;
    public float speed = 0.5f;
    public bool onFloor = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        timer();
    }
    void move(){
        if(onFloor == true){
            if(Input.GetKey("space")){
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                onFloor = false;
            }
        }
        //this could be an else
        if(onFloor == false){
            if(Input.GetKey("s")){
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.down * jumpForce, ForceMode2D.Impulse);
            }   
        }
     
        transform.Translate(Input.GetAxis("Horizontal") * speed,0,0);
    }
    void timer(){
        startTimer += Time.deltaTime;
        Timer.text = "Timer: " + startTimer.ToString("f0");
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "floor"){
            onFloor = true;
            rb.velocity = Vector2.zero;
        }
        if(other.gameObject.tag == "Wall"){
            SceneManager.LoadScene("GameOver");
        }
    }
}
