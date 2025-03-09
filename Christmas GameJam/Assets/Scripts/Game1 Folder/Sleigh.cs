using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleigh : MonoBehaviour
{
    public Sprite SpriteRight;
    public Sprite SpriteLeft;
    public SpriteRenderer spriteRenderer;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update(){
        movement();
    }
    void movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, 0);
        if (Input.GetKeyDown("a"))
        {
            spriteRenderer.sprite = SpriteLeft;
        }
        else if (Input.GetKeyDown("d"))
        {
            spriteRenderer.sprite = SpriteRight;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "presents")
        {
            GameObject.Find("PresentsGathered").GetComponent<PresentsGathered>().PresentsGot += 1;
            Destroy(other.gameObject);
        }
    }
}
//    private void onCollisionEnter2D(Collision2D other)
//    {
//     
//    }
