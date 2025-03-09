using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoss : MonoBehaviour
{
    public GameObject enemyAttack;
    public GameObject enemyBullet;
    public Transform player;
    public Vector3 playerPosition;
    Vector3 position;
    Rigidbody2D rb;
    public float waitMove;
    public float waitMoveMax = 2.0f;
    public Vector2Int directionFacing;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        rb = this.GetComponent<Rigidbody2D>();
        waitMove = waitMoveMax;
        directionFacing = new Vector2Int(0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        print(directionFacing);
        playerPosition = player.transform.position;
        if(waitMove > 0){
            waitMove -= Time.deltaTime;
        }

        // if(position.x > playerPosition.x && waitMove <= 0){
        //     rb.MovePosition(transform.position + -transform.right);
        //     Instantiate(enemyAttack, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        //     waitMove = waitMoveMax;
        // }
        // else if(position.x < playerPosition.x && waitMove <= 0){
        //     rb.MovePosition(transform.position + transform.right);
        //     Instantiate(enemyAttack, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);            
        //     waitMove = waitMoveMax;
        // }
        // if(position.x == playerPosition.x && position.y > playerPosition.y && waitMove <= 0){
        //     rb.MovePosition(transform.position + -transform.up);
        //     Instantiate(enemyAttack, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        //     waitMove = waitMoveMax;

        // }
        // else if(position.x == playerPosition.x && position.y < playerPosition.y && waitMove <= 0){
        //     rb.MovePosition(transform.position + transform.up);
        //     Instantiate(enemyAttack, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        //     waitMove = waitMoveMax;
        // }
        if(waitMove <= 0){
            //up
            if(playerPosition.x == position.x && position.y < playerPosition.y){
                BossMove(transform.position + transform.up, new Vector2Int(0,1));
            }
            //up right
            else if(playerPosition.x > position.x && position.y < playerPosition.y){
                BossMove(transform.position + transform.up + transform.right, new Vector2Int(1,1));
            }
            //right
            else if(playerPosition.x > position.x && position.y == playerPosition.y){
                BossMove(transform.position + transform.right, new Vector2Int(1,0));
            }
            //bottom right
            else if(playerPosition.x > position.x && position.y > playerPosition.y){
                BossMove(transform.position + -transform.up + transform.right, new Vector2Int(1,-1));
            }
            //bottom
            else if(playerPosition.x == position.x && position.y > playerPosition.y){
                BossMove(transform.position + -transform.up, new Vector2Int(0,-1));
            }
            //bottom left
            else if(playerPosition.x < position.x && position.y > playerPosition.y){
                BossMove(transform.position + -transform.right + -transform.up, new Vector2Int(-1,-1));

            }
            //left
            else if(playerPosition.x < position.x && position.y == playerPosition.y){
                BossMove(transform.position + -transform.right, new Vector2Int(-1,0));

            }
            //top left
            else if(playerPosition.x < position.x && position.y < playerPosition.y){
                BossMove(transform.position + transform.up + -transform.right, new Vector2Int(-1,1));
            }
        }
    }
    void BossMove(Vector3 direction, Vector2Int directionAt){
        rb.MovePosition(direction);
        Instantiate(enemyAttack, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity).transform.parent = gameObject.transform;
        Instantiate(enemyBullet, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity).transform.parent = gameObject.transform;
        waitMove = waitMoveMax;
        directionFacing = directionAt;
    }


}
