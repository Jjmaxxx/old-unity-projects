using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject player;
    public PlayerMove playermove;
    public float timer = 0.5f;
    public bool isTouchingFloor = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        playermove = player.GetComponent<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(this.gameObject);
        }
        if (playermove.isFacingRight == true)
        {
            rb.MovePosition(this.transform.position + new Vector3(0.1f, 0, 0));
        }
        else
        {
            rb.MovePosition(this.transform.position - new Vector3(0.1f, 0, 0));
        }

    }

}
