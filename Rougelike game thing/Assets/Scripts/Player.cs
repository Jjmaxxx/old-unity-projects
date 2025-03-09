using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    Rigidbody2D rb;
    public float shootTimer;
    public float shootTimerMax = 1.0f;
    public float moveTimer;
    public float moveTimerDiagonal;
    public float moveTimerMax = 0.5f;
    public GameObject PlayerProjectile;
    public Vector2Int direction; 

    // Start is called before the first frame update
    void Start()
    {
        shootTimer = shootTimerMax;
        rb = this.GetComponent<Rigidbody2D>();
        moveTimer = moveTimerMax;
        moveTimerDiagonal = moveTimerMax;
        direction = new Vector2Int(1,0);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        healthFunction();
        projectile();
    }

    void movement(){
        if(moveTimer > 0){
            moveTimer-= Time.deltaTime;
        }
        if(moveTimerDiagonal > 0){
            moveTimerDiagonal-= Time.deltaTime;
        }
        moveTimerDiagonal-= Time.deltaTime;
        if(moveTimer <= 0){
        if(Input.GetKey("w")){         
            rb.MovePosition(transform.position + transform.up);
            moveTimer = moveTimerMax;
            //pass bullet this variable
        }else if(Input.GetKey("a")){         
            rb.MovePosition(transform.position + -transform.right);
            moveTimer = moveTimerMax;
        }else if(Input.GetKey("s")){         
            rb.MovePosition(transform.position + -transform.up);
            moveTimer = moveTimerMax;
        }else if(Input.GetKey("d")){         
            rb.MovePosition(transform.position + transform.right);
            moveTimer = moveTimerMax;
        }
        }
        if(Input.GetKey("w")){         
            direction = new Vector2Int(0,1);
        }else if(Input.GetKey("a")){         
            direction = new Vector2Int(-1,0);            
        }else if(Input.GetKey("s")){         
            direction = new Vector2Int(0,-1);
        }else if(Input.GetKey("d")){         
            direction = new Vector2Int(1,0);
        }

        //diagonal movement 
        if(Input.GetKey("w") && Input.GetKey("a") && moveTimerDiagonal <= 0){         
            rb.MovePosition(transform.position + transform.up + -transform.right);
            moveTimerDiagonal = moveTimerMax;
        }else if(Input.GetKey("a") && Input.GetKey("s") && moveTimerDiagonal <= 0){         
            rb.MovePosition(transform.position + -transform.up + -transform.right);
            moveTimerDiagonal = moveTimerMax;
        }else if(Input.GetKey("s") && Input.GetKey("d") && moveTimerDiagonal <= 0){         
            rb.MovePosition(transform.position + -transform.up + transform.right);
            moveTimerDiagonal = moveTimerMax;
        }else if(Input.GetKey("w") && Input.GetKey("d") && moveTimerDiagonal <= 0){         
            rb.MovePosition(transform.position + transform.up + transform.right);
            moveTimerDiagonal = moveTimerMax;
        }                        

        // if(Input.GetKey("w") && Input.GetKey("a")){
        //     print("aasdsa");
        // }

    }
    void healthFunction(){
        if(health <= 0){
            Destroy(this.gameObject);
        }
    }
    void projectile(){
        shootTimer -= Time.deltaTime;
        if(Input.GetKey("space") && shootTimer <= 0){
            Instantiate(PlayerProjectile, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity).transform.parent = gameObject.transform;
            shootTimer = shootTimerMax;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Mine"){
            Destroy(other.gameObject);
            health -= 1;
        }
    }
}
