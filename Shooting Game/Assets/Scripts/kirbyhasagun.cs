using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class kirbyhasagun : MonoBehaviour
{
    public GameObject Kirby;
    //extra
    public GameObject Bullet;
    SpriteRenderer spriteRenderer;
    public int health = 3;
    public Text Life;
    public Text BulletsLeft;
    public Text AmmoBoxesLeft;
    public Sprite kirbyWithAGun;
    public Sprite kirbyHurt;
    public float spriteTimer = 1.0f;
    public int isKirbyHurt = 0;
    public int ammo = 6;
    public int ammoBox = 3;

    public bool isRunning = false;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        onMouseClick();
        lifeBar();
        switchSprites();
        outOfAmmo();
    }

    void onMouseClick(){
        Vector2 position = transform.position;
        if(Input.GetMouseButtonDown(0) && GameObject.FindGameObjectsWithTag("bullet").Length < 1 && ammo > 0){
            Instantiate(Bullet, new Vector2(position.x - 2,position.y + 0.4f),Quaternion.identity);
            ammo--;
            //rather than constantly checking for < 0 ammo trigger the coroutine here 
            isRunning = false;
         }
    }

    void lifeBar(){
        if(health <= 0){
            SceneManager.LoadScene("GameOver");
        }
        Life.text = "Health: " + health.ToString();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "zombie"){
            health--;
            spriteRenderer.sprite = kirbyHurt;
            isKirbyHurt = 1;
        }
        if(other.gameObject.tag == "bullet"){
            health--;
            spriteRenderer.sprite = kirbyHurt;
            Destroy(other.gameObject);
            isKirbyHurt = 1;
        }

        //coroutine is really the best option here, try your best 
        //in the future if you get stuck with a coroutine or some code you think is the best way
        //comment it THEN bootleg 
    }

    void switchSprites(){
        spriteTimer -= Time.deltaTime;
        if(spriteTimer <= 0){
            spriteTimer = 1.0f;
        }
        if(isKirbyHurt == 1 && spriteTimer <= 0.01f){
            spriteRenderer.sprite = kirbyWithAGun;
            isKirbyHurt = 0;
            spriteTimer = 1.0f;
        }
    }

    void outOfAmmo(){
        if(ammo < 1 && ammoBox >= 1){
            if(isRunning == false){
                StartCoroutine(reloadTime());
                isRunning = true;
                print("running");      
            }
        }
        //organizer alllll your UI Stuff into one function 
        //then this could just be event based 
        BulletsLeft.text = "Bullets: " + ammo.ToString();
        AmmoBoxesLeft.text = "Ammo Boxes: " + ammoBox.ToString();

    }
    IEnumerator reloadTime(){
        yield return new WaitForSeconds(5);
        ammo = 6;
        ammoBox -= 1;
    }
    
}
