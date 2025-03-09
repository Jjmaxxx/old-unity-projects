using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour
{
    player Player;
    Vector2Int movement;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Player = transform.parent.gameObject.GetComponent<player>();
        movement = Player.direction;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2Int(movement.x,movement.y);
        this.GetComponent<Rigidbody2D>().velocity *= 0.5f;
    }   
}
