using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBossBullet : MonoBehaviour
{
    TestBoss testBoss;
    Vector2Int movement;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        testBoss = transform.parent.gameObject.GetComponent<TestBoss>();
        movement = testBoss.directionFacing;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + new Vector3(movement.x,movement.y,0));
    }

}
