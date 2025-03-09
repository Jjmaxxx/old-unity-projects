using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody2D rb;
    public float speed; 
    public Colors colors;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        colors = this.GetComponent<Colors>();
        colors.coloring = "white";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            rb.MovePosition(this.transform.position + new Vector3(0, speed * Time.deltaTime, 0));
        }
        if(Input.GetKey("a")){
            rb.MovePosition(this.transform.position + new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey("s")){
            rb.MovePosition(this.transform.position + new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if(Input.GetKey("d")){
            rb.MovePosition(this.transform.position + new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetMouseButtonDown(0) && GameObject.FindGameObjectsWithTag("bullet").Length < 10){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = mousePosition - this.transform.position;
            direction.z = 0;
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
            bul.GetComponent<bullet>().direction = direction;
        }
    }
    void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "tile"){
            Colors tileColor = other.gameObject.GetComponent<Colors>();
            if(tileColor.coloring == "red"){
                this.GetComponent<Renderer>().material.color = Color.red;       
                colors.coloring = "red";
            }else if(tileColor.coloring == "yellow"){
                this.GetComponent<Renderer>().material.color = Color.yellow;       
                colors.coloring = "yellow";
            }else if(tileColor.coloring == "blue"){
                this.GetComponent<Renderer>().material.color = Color.blue;       
                colors.coloring = "blue";    
            }else if(tileColor.coloring == "white"){
                this.GetComponent<Renderer>().material.color = Color.white;       
                colors.coloring = "white";
            }       
        }
        if(other.gameObject.tag == "enemyBullet"){
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "enemyBullet"){
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }        
    }
    
}
