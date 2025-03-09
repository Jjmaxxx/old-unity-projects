using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Fireball;
    public float speed = 1.0f;
    public float jumpSpeed = 2.0f;
    public Rigidbody2D rb;
    public float jumpTimer = 0.3f;
    public int PlayerState;
    public bool isTouchingFloor = true;
    public bool isFacingRight = true;
    public float flowerCoolDown;
    public Sprite NormalSprite;
    public Sprite BigPlayer;
    public Sprite FlowerState;
    public Sprite NormalSprite2;
    public Sprite BigPlayer2;
    public Sprite FlowerState2;
    public SpriteRenderer spriterenderer;
    BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        flowerCoolDown = 0.5f;
        PlayerState = 0;
        rb = GetComponent<Rigidbody2D>();
        spriterenderer = this.GetComponent<SpriteRenderer>();
        collider = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        flowerCoolDown -= Time.deltaTime;
        //rb.MovePosition(new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed,transform.position.y,0));
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        rb.MovePosition(transform.position + move * speed);
        //transform.Translate(0, -0.1f, 0);
        if (Input.GetKey("space") && jumpTimer >= 0 && isTouchingFloor == true)
        {
            jumpTimer -= Time.deltaTime;
            rb.AddForce(transform.up * jumpSpeed,ForceMode2D.Impulse);
        }
        if (PlayerState == 2)
        {
            if (Input.GetKey("return") && isFacingRight == true && flowerCoolDown <= 0)
            {
                Instantiate(Fireball, new Vector2(this.transform.position.x + 1.0f, this.transform.position.y), Quaternion.identity);
                flowerCoolDown = 0.5f;
            }
            else if(Input.GetKey("return") && isFacingRight == false && flowerCoolDown <= 0)
            {
                Instantiate(Fireball, new Vector2(this.transform.position.x - 1.0f, this.transform.position.y), Quaternion.identity);
                flowerCoolDown = 0.5f;
            }
        }
        if(Input.GetKey("a") && PlayerState == 0)
        {
            spriterenderer.sprite = NormalSprite2;
            isFacingRight = false;
        }else if(Input.GetKey("d") && PlayerState == 0)
        {
            spriterenderer.sprite = NormalSprite;
            isFacingRight = true;
        }
        if (Input.GetKey("a") && PlayerState == 1)
        {
            spriterenderer.sprite = BigPlayer2;
            isFacingRight = false;
        }
        else if (Input.GetKey("d") && PlayerState == 1)
        {
            spriterenderer.sprite = BigPlayer;
            isFacingRight = true;
        }
        if (Input.GetKey("a") && PlayerState == 2)
        {
            spriterenderer.sprite = FlowerState2;
            isFacingRight = false;
        }
        else if (Input.GetKey("d") && PlayerState == 2)
        {
            spriterenderer.sprite = FlowerState;
            isFacingRight = true;
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "floor")
        {
            isTouchingFloor = true;
            jumpTimer = 0.3f;
        }
        else
        {
            isTouchingFloor = false;
        }


        if (other.gameObject.tag == "break")
        {
            Destroy(other.transform.parent.gameObject);
            GameObject.Find("UI Elements").GetComponent<UIManager>().points += 50;     
        }

        if(other.gameObject.tag == "mushroom")
        {
            isTouchingFloor = true;
            PlayerState = 1;
            spriterenderer.sprite = BigPlayer;
            Destroy(other.gameObject);
            collider.size = new Vector2(1.6f, 2.40f);
            collider.offset = new Vector2(0.02f,0.04f);
        }
        if (other.gameObject.tag == "flower")
        {
            PlayerState = 2;
            spriterenderer.sprite = FlowerState;
            Destroy(other.gameObject);
            collider.size = new Vector2(1.6f, 2.40f);
            collider.offset = new Vector2(0.02f, 0.04f);
        }
        if(other.gameObject.tag == "GoombaStomp")
        {
            Destroy(other.gameObject.transform.parent);
        }
        if (other.gameObject.tag == "NotGoomba" && PlayerState == 2)
        {
            PlayerState = 1;
        }
        else if(other.gameObject.tag == "NotGoomba" && PlayerState == 1)
        {
            collider.size = new Vector2(1.78f, 1.61f);
            collider.offset = new Vector2(0, 0);
            PlayerState = 0;
        }
        else if(other.gameObject.tag == "NotGoomba" && PlayerState == 0)
        {
           Destroy(this.gameObject);
        }
    }
   
}
