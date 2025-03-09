using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed = -0.5f;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveBullet();
        //technically here you could probably break the rule 
        //u are TECHNICALLY inneficcient here because ur doing a function call 
    }

    void moveBullet(){
        //sets currentMousePosition to a vector
        Vector3 positionOfMouse = Input.mousePosition;
        positionOfMouse = Camera.main.ScreenToWorldPoint(positionOfMouse);

        //ScreenToWorldPoint takes it from screenspace to worldspace 
        //you can't do screenspace for calculations;mostly for UI
        //worldSpace is the xyz grid 
        

        //makes it so mouse and object positions get subtracted to let object face toward mouse
        Vector2 directionOfBullet = new Vector2( transform.position.x - positionOfMouse.x, transform.position.y - positionOfMouse.y );
        //sets transform to face mouse
        transform.right = directionOfBullet;
        rb.velocity = new Vector2(directionOfBullet.x * speed, directionOfBullet.y * speed);
    }

}
