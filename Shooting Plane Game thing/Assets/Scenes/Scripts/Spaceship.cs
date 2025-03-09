using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Spaceship : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.2f;
    public GameObject Bullet;
    public GameObject Asteroid;

    //just delete extra methods
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mayyybe just seperate these into methods to improve code scaleability
        //generally you want update to have very little code in it besides method calls 

        transform.Translate(Input.GetAxis("Horizontal") * speed,Input.GetAxis("Vertical") * speed,0);
        Vector2 position = transform.position;
        if(Input.GetKey("space")){
            //Quarternion identity corresponds to "no rotation" - the object is perfectly aligned with the world or parent axes.

            Instantiate(Bullet, new Vector2(position.x + 1,position.y),Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //generally with multiple collisions use an elif chain of priority 
        //use an elif chain, stuff at the top of the chain will have greater priority than collisions at the bottom of the chain 
        if(other.gameObject.tag == "Asteroid"){
            Destroy(this.gameObject);
            SceneManager.LoadScene("DeathScreen",LoadSceneMode.Additive);
            // print("death");
        }
        if(other.gameObject.tag == "Boundary"){
            print("work for the love of god");
            SceneManager.LoadScene("DeathScreen",LoadSceneMode.Additive);            

            Destroy(this.gameObject);
        }               

    }


}
