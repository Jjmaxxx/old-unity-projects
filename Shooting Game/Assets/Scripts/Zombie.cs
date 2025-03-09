using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie : MonoBehaviour
{
    public int health = 3;
    public GameObject ZombieDude;
    //you dont really need a reference to the gameobject your in you already have access to it through the this keyword
    public float timer = 0;
    public float force = 0.7f;
    public Text TimerDisplay;
    public GameObject Forcefield;
    Rigidbody2D rb;
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.02f,0,0);
        healthBar();
        checkZombieCount();
        timerCount();
    }
    void healthBar(){
        if(health <= 0){
            Destroy(this.gameObject);
        }
    }

    //this should be in a spawner object 
    void checkZombieCount(){
        if(GameObject.FindGameObjectsWithTag("zombie").Length < 4){
            Instantiate(ZombieDude, new Vector2(-7,-2.34f), Quaternion.identity);
        }else if(timer >= 30){
            if(GameObject.FindGameObjectsWithTag("zombie").Length < 6){
                Instantiate(ZombieDude, new Vector2(Random.Range(-11,-7), -2.34f), Quaternion.identity);
            }
        }
    }
    void timerCount(){
        timer += Time.deltaTime;
        TimerDisplay.text = "Time Survived: " + timer.ToString("f0");

    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "bullet"){
            health--; 
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "kirbyhasagun"){
            health = 0;
            //just destroy it 

            //kirby should make this 
            //if you had other enemies they would also need to do this :(
            Instantiate(Forcefield, new Vector2(7,-2.54f), Quaternion.identity);
        }
        if(other.gameObject.tag == "Boundary"){
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "ZombieRange"){
            rb.AddForce(Vector2.right * force, ForceMode2D.Impulse);
        }
    }
}
